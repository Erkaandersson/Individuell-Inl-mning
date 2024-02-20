
using Newtonsoft.Json;

namespace StatisticsTest2
{
    using Statistics;
    public class StatisticsTest
    {
        //Jag va tvungen att �ndra en variabel som var satt till -88 i Mean() funktionen till 0 f�r-
        // att programmet skulle fungera korrekt. 
        //Sedan fick jag l�gga in json filen i en mapp f�r att kunna komma �t datan ifr�n testet. 
        //Fick ta bort static ifr�n class statistics f�r att protection leveln skapade problem. 
        //Anv�nder using Statistics f�r att l�ttare komma �t det ifr�n klasserna. 
       
        [Fact]
        public void MaxValue() 
        {  
            //arrange 
   
            int expectedValue = 378;

            //act 
            int actual = Statistics.Maximum();

            //assert 
            
            Assert.Equal(expectedValue, actual);
        }
        [Fact]
        public void MinValue()
        {
            int expectedValue = -42;

            int actual = Statistics.Minimum();

            Assert.Equal(expectedValue, actual);
        }
        [Fact]
        public void MeanValue()
        {
            double expectedValue = 167.3088;

            double actual = Statistics.Mean();

            Assert.Equal(expectedValue, actual);
        }
        [Fact]
        public void MedianValue()
        {
            double expectedValue = 165;

            double actual = Statistics.Median();

            Assert.Equal(expectedValue, actual);
        }
        [Fact]
        public void ModeValue()
        {
            int[] expectedValue = { 228, 87, 31 };

            int[] actual = Statistics.Mode();

            Assert.Equal(expectedValue, actual);
        }
        [Fact]
        public void RangeValue()
        {
            int expectedValue = 420;

            int actual = Statistics.Range();

            Assert.Equal(expectedValue, actual);
        }
        [Fact]
        public void StandardDeviationValue()
        {
            double expectedValue = 122.3;

            double actual = Statistics.StandardDeviation();

            Assert.Equal(expectedValue, actual);
        }
    }
}