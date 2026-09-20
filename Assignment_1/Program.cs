namespace  Assignment_1;

class Program
{
    static void Main(string[] args)
    {
        
        pet myPet = new pet();
        album myAlbum = new album();
        ticket myTicket = new ticket();
        
        myPet.setInfo();
        myPet.showInfo();

        myAlbum.setInfo();
        myAlbum.showInfo();

        myTicket.setInfo();
        myTicket.showInfo();

        
    }
}
