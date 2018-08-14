using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace romaMovie
{
    class Movie : IEquatable<Movie>
    {
        public string id;
        public string name;
        public string url;
        public Movie(string id,string name="",string url="")
        {
            this.id = id;
            this.name = name;
            this.url = url;
        }

        public bool Equals(Movie other) => id.Equals(other.id) && name.Equals(other.name) && url.Equals(other.url);

        public override int GetHashCode()
        {
            var hashCode = -1842963244;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(url);
            return hashCode;
        }
    }
}
