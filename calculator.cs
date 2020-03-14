using System;

public static class GlobalMembers
{
	static void Main(string[] args)
	{
					float x;
					float y;
					float hasil;
					float pilih;

					kalkulator :
									Console.Write("Pilih menu  calculator: ");
									Console.Write("\n");
									string Penjumlahan = "1. Penambahann";
									Console.Write(Penjumlahan);
									Console.Write("\n");
									string Pengurangan = "2. Pengurangan";
									Console.Write(Pengurangan);
									Console.Write("\n");
									string Perkalian = "3. Perkalian";
									Console.Write(Perkalian);
									Console.Write("\n");
									string Pembagian = "4. Pembagian";
									Console.Write(Pembagian);
									Console.Write("\n");
									Console.Write("\n");

									int z;
									Console.Write("Input nomnor menu [1..4]: ");
									z = int.Parse(ConsoleInput.ReadToWhiteSpace(true));

									Console.Write("Inputkan nilai a = ");
									x = float.Parse(ConsoleInput.ReadToWhiteSpace(true));
									Console.Write("Inputkan nilai b = ");
									y = float.Parse(ConsoleInput.ReadToWhiteSpace(true));

									if (z == 1)
									{
													hasil = x + y;
													Console.Write("Hasil Penambahann = ");
													Console.Write(hasil);
													Console.Write("\n");
									}
									else if (z == 2)
									{
													hasil = x - y;
													Console.Write("Hasil Pengurangan = ");
													Console.Write(hasil);
													Console.Write("\n");
									}
									else if (z == 3)
									{
													hasil = x * y;
													Console.Write("Hasil Perkalian = ");
													Console.Write(hasil);
													Console.Write("\n");
									}
									else if (z == 4)
									{
													hasil = x / y;
													Console.Write("Hasil Pembagian = ");
													Console.Write(hasil);
													Console.Write("\n");
									}
									Console.Write("========================================================");
									Console.Write("\n");
									Console.Write("Coba Lagi [1]");
									Console.Write("\n");
									Console.Write("Keluar    [2]");
									Console.Write("\n");
									Console.Write("========================================================");
									Console.Write("\n");
									Console.Write("Pilih : ");
									pilih = float.Parse(ConsoleInput.ReadToWhiteSpace(true));
									if (pilih == 1F)
									{
													goto kalkulator;
									}
									if (pilih == 2F)
									{
										Console.Write("\t\t\t\t========================================================");
										Console.Write("\n");
										Console.Write("\t\t\t\t     Terima Kasih Telah Menggunakan Kalkulator Ini");
										Console.Write("\n");
										Console.Write("\t\t\t\t========================================================");
										Console.Write("\n");
									}
	}
}

//Helper class added by C++ to C# Converter:

//----------------------------------------------------------------------------------------
//	Copyright © 2006 - 2020 Tangible Software Solutions, Inc.
//	This class can be used by anyone provided that the copyright notice remains intact.
//
//	This class provides the ability to convert basic C++ 'cin' and C 'scanf' behavior.
//----------------------------------------------------------------------------------------
internal static class ConsoleInput
{
	private static bool goodLastRead = false;
	public static bool LastReadWasGood
	{
		get
		{
			return goodLastRead;
		}
	}

	public static string ReadToWhiteSpace(bool skipLeadingWhiteSpace)
	{
		string input = "";

		char nextChar;
		while (char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
		{
			//accumulate leading white space if skipLeadingWhiteSpace is false:
			if (!skipLeadingWhiteSpace)
				input += nextChar;
		}
		//the first non white space character:
		input += nextChar;

		//accumulate characters until white space is reached:
		while (!char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
		{
			input += nextChar;
		}

		goodLastRead = input.Length > 0;
		return input;
	}

	public static string ScanfRead(string unwantedSequence = null, int maxFieldLength = -1)
	{
		string input = "";

		char nextChar;
		if (unwantedSequence != null)
		{
			nextChar = '\0';
			for (int charIndex = 0; charIndex < unwantedSequence.Length; charIndex++)
			{
				if (char.IsWhiteSpace(unwantedSequence[charIndex]))
				{
					//ignore all subsequent white space:
					while (char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
					{
					}
				}
				else
				{
					//ensure each character matches the expected character in the sequence:
					nextChar = (char)System.Console.Read();
					if (nextChar != unwantedSequence[charIndex])
						return null;
				}
			}

			input = nextChar.ToString();
			if (maxFieldLength == 1)
				return input;
		}

		while (!char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
		{
			input += nextChar;
			if (maxFieldLength == input.Length)
				return input;
		}

		return input;
	}
}
