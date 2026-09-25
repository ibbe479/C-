import { useState } from "react";
import "./App.css";

function App() {
  const [Age, setAge] = useState("");

  const handleSubmit = async (e) => {
    const response = await fetch("http://localhost:8000/api/validate-age", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ age: parseInt(Age) }),
    });

    const data = await response.json();
    console.log(data);
  };

  return (
    <>
      <fieldset className="fieldset bg-base-200 border-base-300 rounded-box w-xs border p-4">
        <legend className="fieldset-legend">Age</legend>

        <label className="label">How old are you</label>
        <input
          type="text"
          className="input"
          placeholder="Write your age here"
          value={Age}
          onChange={(e) => setAge(e.target.value)}
        />
        <button className="btn btn-neutral mt-4" onClick={handleSubmit}>
          submit
        </button>
      </fieldset>
    </>
  );
}

export default App;
