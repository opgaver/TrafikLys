TrafikLys trafikLys = new TrafikLys();
Console.ReadLine();

class TrafikLys {
    
    public TrafikLysTilstand Tilstand { get; private set; }
    
    private System.Timers.Timer Timer = new System.Timers.Timer();
    private int[] Tider = new int[] { 5000, 2000, 10000, 2000 };

    public TrafikLys()
    {
        this.Tilstand = TrafikLysTilstand.Rød;    
        this.Timer.Interval = this.Tider[0];
        this.Timer.Elapsed += (sender, e) => SkiftTilstand();
        this.Timer.Start();
        PrintTilstand();
    }

    public void SkiftTilstand()
    {
        switch (this.Tilstand)
        {
            case TrafikLysTilstand.Rød:
                this.Tilstand = TrafikLysTilstand.RødGul;
                this.Timer.Interval = this.Tider[1];
                break;
            case TrafikLysTilstand.RødGul:
                this.Tilstand = TrafikLysTilstand.Grøn;
                this.Timer.Interval = this.Tider[2];
                break;
            case TrafikLysTilstand.Grøn:
                this.Tilstand = TrafikLysTilstand.Gul;                    
                break;
            case TrafikLysTilstand.Gul:
                this.Tilstand = TrafikLysTilstand.Rød;
                this.Timer.Interval = this.Tider[0];
                break;
            default:
                throw new Exception("Ukendt tilstand");
        }
        PrintTilstand();
    }

    public void Reset()
    {
        this.Tilstand = TrafikLysTilstand.Rød;
    }

    private void PrintTilstand()
    {
        Console.WriteLine(this.Tilstand);
    }

}

enum TrafikLysTilstand
{
    Rød,
    RødGul,
    Grøn,
    Gul
}