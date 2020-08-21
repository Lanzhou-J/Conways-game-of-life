using System;
using Xunit;

namespace GameOfLife.Tests
{
    public class UnitTest1
    {
        public int[][] Tick(int[][] input){
          return input;
        }

        
        // public int[][] RunRules(int[][]){
        //   return null;
        // }

        // [Fact]
        // public void Test1()
        // {
        //   // arange
        //   var initial = new[] {
        //     new[]{0,0,0,0},
        //     new[]{0,1,1,0},
        //     new[]{0,1,1,0},
        //     new[]{0,0,0,0}
        //   };

        //   //act
        //   var output = Tick(initial);

        //   //assert
        //   Assert.Equal(initial, output);
        // }

        [Fact]
        public void CellRule1()
        {
          //arrange
          var initial = new[] {
            new[]{0,0,0},
            new[]{0,1,0},
            new[]{0,0,0},
          };
          var results = new[] {
            new[]{0,0,0},
            new[]{0,0,0},
            new[]{0,0,0},
          };
          
          //act
          var output = Tick(initial);
          
          //assert
          Assert.NotEqual(initial,output);
          // Assert.Equal(results,output);
        }
    }
}
