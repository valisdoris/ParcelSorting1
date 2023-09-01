using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParcelSorting1;

namespace BoxSortingLine.Test
{
    public class BoxSortingTest
    {
        [Fact]
        public void When_ParcelHasNewDimensionsAndSortingLineHasNewDimensions_ThenParcelCanNotFitSortingLine()
        {
            var boxSizes = new List<BoxSize>()
            {
                new BoxSize
                    {
                        Length = 150,
                        Width = 80,
                        SortingLineParams = new List<SortingLineParam>
                        {
                            new SortingLineParam
                            {
                                Width =500,
                            },
                            new SortingLineParam
                            {
                                Width = 560
                            }
                        }



                }
            };

            bool result = Program.FirstParcelLine(boxSizes);

            Assert.False(result);


        }   
    }

               
         
          
}

    

