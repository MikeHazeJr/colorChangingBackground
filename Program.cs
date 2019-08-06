using System;                                                           /*  Visual Studio Community 2019 is smart           */
using System.Collections.Generic;                                       /*   and has automatically marked these other       */
using System.Linq;                                                      /*    classes as un-used by graying them out        */
using System.Text;                                                      /*     All the grayed out ones may be deleted       */
using System.Threading.Tasks;                                           /*  (Everything from lines 2 through 5, delete)     */


/*  This application consists of the following elements:
 *  >   Main method                                                 18 - 45
 *  >   creating variables and initializing them                    21 - 22
 *  >   calling a mmethod from another class using dot-notation     25, 33, 37, 40, 41
 *  >   while-loop and iteration basics (while-true)                28 - 45
 *  >   if-else statements, using conditional branching             33 - 40
 *  >   using delays to slow down processing for testing            44                  */


namespace colorChangingBackground
{                                                                       /*  namespace 'colorChangingBackground' ends here   */
    class Program                                                       /*  class 'Program' begins here */
    {

        static void Main()
        {   /*  method 'Main' begins here   */

            ConsoleColor defaultColor = ConsoleColor.Black;             /*  set default color as a variable of type 'ConsoleColor'                  */
            ConsoleColor secondColor = ConsoleColor.Green;              /*  set second color as a variable  of type 'ConsoleColor'                  */

            Console.BackgroundColor = defaultColor;                     /*  set console color to 'defaultColor' value                               */

            while (true)                                                /*  this loop will constantly run until it is broken                        */
            {                                                           /*  loop body begins here                                                   */

                                                                        /*  if statement checks conditions within parentheses                       */
                if (Console.BackgroundColor == defaultColor)            /*  true                                                                    */
                {
                    Console.BackgroundColor = secondColor;
                }
                else                                                    /*  false                                                                   */
                {
                    Console.BackgroundColor = defaultColor;
                }

                Console.Clear();                                        /*  Console.Clear(); clears the console, refreshing it visually             */
                System.Threading.Thread.Sleep(125);                     /*  wait until timer runs out, measured in milliseconds (1/1000 second)     */
                                                                        /*  125ms is equal to 1/8 second                                            */

            }                                                           /*  loop ends here                                                          */

        }                                                               /*  method 'Main' ends here                                                 */

    }                                                                   /*  class 'Program' ends here                                               */

}                                                                       /*  namespace 'colorChangingBackground' ends here                           */
