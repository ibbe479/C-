from fastapi import FastAPI, Request
from fastapi.middleware.cors import CORSMiddleware
import uvicorn

app = FastAPI()

app.add_middleware(
    CORSMiddleware,
    allow_origins=["http://localhost:5173"],  # Vites default-port
    allow_methods=["*"],
    allow_headers=["*"],
)

@app.post("/api/validate-age")
async def validate_age(request: Request):
    data = await request.json()
    age = data.get("age")

    if age is None:
        return {"error": "Ingen ålder skickades"}

    is_adult = age >= 18
    return {
        "age": age,
        "isAdult": is_adult,
        "message": "Du är myndig!" if is_adult else "Du är inte myndig än."
    }

if __name__ == "__main__":
     uvicorn.run("app:app", host="127.0.0.1", port=8000, reload=True)
