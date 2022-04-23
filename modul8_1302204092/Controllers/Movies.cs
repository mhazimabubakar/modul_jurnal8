using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul8_1302204092.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Movies : ControllerBase
    {
        public static List<string> stars1 = new List<string>
        {
            "Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sandler"
        };

        public static List<string> stars2 = new List<string>
        {
            "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton"
        };
        
        public static List<string> stars3 = new List<string>
        {
            "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"
        };

        public static List<Movie> listMovie = new List<Movie>
        {
            new Movie ("The Shawshank Redemption", "Frank Darabont", stars1, "Two imprisoned men bond over a number " +
                "of years, finding solace and eventual redemption through acts of common decency."),
            new Movie ("The Godfather", "Francis Ford  Coppola", stars2, "The aging patriarch of an organized crime " +
                "dynasty in postwar New York City transfers control of his clandestine empire to his reluctant " +
                "youngest son."),
            new Movie ("The Dark Knight", "Christopher Nolan", stars3, "When the menace known as the Joker wreaks " +
                "havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and " +
                "physical tests of his ability to fight injustice.")
        };

        // GET: api/<Movies>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return listMovie;
        }

        // GET api/<Movies>/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return listMovie[id];
        }

        // POST api/<Movies>
        [HttpPost]
        public void Post([FromBody] Movie tambah)
        {
            listMovie.Add(tambah);
        }

        //// PUT api/<Movies>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<Movies>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMovie.RemoveAt(id);
        }
    }
}
