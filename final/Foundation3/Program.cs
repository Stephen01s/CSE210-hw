using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("100 E", "Rexburg", "ID");
        Receptions reception = new Receptions("wedding", "wedding of Jim and Jane", "June 5", "6 pm", address1, "Email me to rsvp at jimmyjohns@gmail");
        Address address2 = new Address("200 S", "Idaho Falls", "ID");
        Outdoor outdoor = new Outdoor("Sledding", "City sledding day", "December 28", "7 pm", address2, "Snowy");
        Address address3 = new Address("300 W", "Salt lake city", "UT");
        Lectures lecture = new Lectures("Spiritual", "devotional", "Jan 4", "8 pm", address3, "John doe", 360);

        // reception.StandardDetails();
        // outdoor.StandardDetails();
        // lecture.StandardDetails();

        reception.FullDisplay();
        outdoor.FullDisplay();
        lecture.FullDisplay();

        // reception.ShortDisplay();
        // outdoor.ShortDisplay();
        // lecture.ShortDisplay();


    }
}