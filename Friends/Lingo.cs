namespace Friends
{
    class Lingo
    {
        public List<Saying> Sayings { get; set; } = [];

        public Lingo()
        {
            Sayings = [
               new ("Ingen ko på isen"),
               new ("Den som i ungdomen förstör fågelbon antänder byar i ålderdomen"),
               new ("Av hampgarn gör man inga silkesstrumpor"),
               new ("Tala inte med en dåre om en sten om du inte vill ha den i huvudet"),
               new ("Bättre fly än illa fäkta"),
               new ("Stå för fiolerna"),
               new ("Saken är biff"),
               new ("När det kommer till kritan"),
               new ("Mycket väsen för lite ull sa käringen som klippte grisen"),
               new ("Man ska inte sätta bocken som trädgårdsmästare")
            ];
        }
    }
}
