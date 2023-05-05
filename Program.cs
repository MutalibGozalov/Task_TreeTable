
using AbstractClass.Models;
using Spectre.Console;
using System.Collections;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        Piano piano = new("9'8", "Yamaha", "Yamaha CFX Akustik Tam Kuyruklu Piyano", 388232100M);
        Kenam keman = new Kenam(arse: "HaoYun HV92", brand: "Yamaha", model: "YSV13141", price: 38.03400M);
        Gitar gitar = new Gitar("mgntc array", "Yamaha", "WLHJ76", 8800.97M);
        Flute flute = new Flute("Plastic", "Yamaha", "HV21", 456.45M);

        piano.DefaultSes();

        Muzisyen pionist = new("Vladislav", "Spiltslav", piano);
        Muzisyen kemanci = new("Hamza", "Kemansoy", keman);
        Muzisyen gitarci = new("John", "Smith", gitar);
        Muzisyen flutcu = new("Jmaes", "Frano", flute);

        ArrayList muzisyenler = new ArrayList();
        muzisyenler.Add(pionist);
        muzisyenler.Add(gitarci);
        muzisyenler.Add(flutcu);
        muzisyenler.Add(kemanci);

        ArrayList enstrumanlar = new ArrayList();
        enstrumanlar.Add(piano);
        enstrumanlar.Add(keman);
        enstrumanlar.Add(gitar);
        enstrumanlar.Add(flute);




        // Muzisyen Tables
        var musizyenTable = new Table();

        foreach (var p in typeof(Muzisyen).GetProperties().OrderBy(x => x.Name))
        {
            musizyenTable.AddColumn(p.Name);
           
        }
        foreach (var muzisyen in muzisyenler)
        {
            var pr = muzisyen.GetType().GetProperties().OrderBy(x => x.Name);
            List<string> proplist = new List<string>();
            foreach (var v in pr)
                proplist.Add(v.GetValue(muzisyen).ToString());

            musizyenTable.AddRow(proplist.ToArray());
        }


        // Create the tree
        var root = new Tree("RNET102");

        // Add some nodes
        var foo = root.AddNode("[yellow]Musizyen[/]");
        var table2 = foo.AddNode(musizyenTable);

        // Render the tree
        AnsiConsole.Write(root);



        //Enstruman tables
        var enstrumanTable = new Table();

        foreach (var p in typeof(Kenam).GetProperties().OrderBy(x => x.Name))
        {
            enstrumanTable.AddColumn(p.Name);

        }
        foreach (var enstruman in enstrumanlar)
        {
            var pr = enstruman.GetType().GetProperties().OrderBy(x => x.Name);
            List<string> proplist = new List<string>();
            foreach (var v in pr)
                proplist.Add(v.GetValue(enstruman).ToString());

            enstrumanTable.AddRow(proplist.ToArray());
        }


        // Create the tree
        var root2 = new Tree("RNET102");

        // Add some nodes
        var foo2 = root2.AddNode("[yellow]Enstruman[/]");
        var table3 = foo2.AddNode(enstrumanTable);

        // Render the tree
        AnsiConsole.Write(root2);


    }
}