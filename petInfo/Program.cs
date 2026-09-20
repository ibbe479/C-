namespace petInfo;

class Program
{
    static void Main(string[] args)
    {
        
        pet myPet = new pet();
        album myAlbum = new album();
        
        myPet.setInfo();
        myPet.showInfo();

        myAlbum.setInfo();
        myAlbum.showInfo();

        
    }
}
