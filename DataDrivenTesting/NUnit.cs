using System.Collections.ObjectModel;

namespace DataDrivenTesting
{

    public class NUnit
    {
 
        [TestCase("Gigi, Mati, Jacub", 0, "Gigi")]
        [TestCase("Gigi, Mati, Jacub", 1, "Mati")]
        [TestCase("Gigi, Mati, Jacob", 2, "Jacob")]

        public void TestGetNameByValidIndex(string collection, int index, string result)
        {
            var names = new Collection<string>(collection.Split(", "));
            var name = names[index];

            Assert.That(name, Is.EqualTo(result));
            Assert.That(names.Count == 3);
        }

     
    }
}