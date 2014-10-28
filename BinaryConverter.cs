// -------------------------------------------------------------------
// Department of Electrical and Computer Engineering
// University of Waterloo
//
// Student Name: Jie Yi Jhony Juan Ding
// Userid: jyjjuand
//
// Assignment: Programming Assignment # 2
// Submission Date: 29/09/2014
//
// I declare that, other than the acknowledgements listed below,
// this program is my original work.
//
// Acknowledgements:
// -------------------------------------------------------------------

using System;

// This class converts an unsigned integer input by the user into
// its binary equivalent.
class BinaryEncoder
{
	// Main( ) method for the class
	static void Main( )
	{
		uint number; // unsigned integer to be input by the user
		uint onBit; // value of a bit "turned on" at a specified exponent
		
		// Display program title
		Console.WriteLine( "Binary Encoder\n" );
		
		// Prompt the user to enter an unsigned integer
		Console.Write( "Enter an unsigned integer number: " );
		
		// Check if the input is valid ( is a unsigned integer )
		// If it is, assigned it to number.
		if( uint.TryParse( Console.ReadLine( ), out number) )
		{
			Console.Write( "\nThe binary encoding of {0} is ", number );
			
			// Convert number into binary
			for( int n = 31; n >= 0; n-- )
			{
				// Assign onBit the value of a bit "turned on"
				onBit = (uint) Math.Pow( 2, n );
				
				// Check if the bit is "turned on" for the number
				if( number >= onBit )
				{
					// Display a 1 if bit is on
					Console.Write( 1 );
					
					// Subtract the value of the "on" bit to check the next bit
					number -= onBit;
				}
				else
				{
					// Display a 0 if bit is off
					Console.Write( 0 );
				}
			}
		}
		else
		{
			// Display error message if input is invalid
			Console.WriteLine( "\nYour input is invalid. The program will terminate now." );
		}
	} // end of Main( ) method
} // end of BinaryEncoder class