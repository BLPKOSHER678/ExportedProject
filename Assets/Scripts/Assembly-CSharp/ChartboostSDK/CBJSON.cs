using System;
using System.Collections;
using System.IO;
using System.Text;

namespace ChartboostSDK
{
	public static class CBJSON
	{
		private sealed class Parser : IDisposable
		{
			private enum TOKEN
			{
				NONE = 0,
				CURLY_OPEN = 1,
				CURLY_CLOSE = 2,
				SQUARED_OPEN = 3,
				SQUARED_CLOSE = 4,
				COLON = 5,
				COMMA = 6,
				STRING = 7,
				NUMBER = 8,
				TRUE = 9,
				FALSE = 10,
				NULL = 11
			}

			private const string WORD_BREAK = "{}[],:\"";

			private StringReader json;

			private char PeekChar
			{
				get
				{
					return default;
				}
			}

			private char NextChar
			{
				get
				{
					return default;
				}
			}

			private string NextWord
			{
				get
				{
					return default;
				}
			}

			private TOKEN NextToken
			{
				get
				{
					return default;
				}
			}

			private Parser(string jsonString)
			{
			}

			public static bool IsWordBreak(char c)
			{
				return default;
			}

			public static object Parse(string jsonString)
			{
				return default;
			}

			public void Dispose()
			{
			}

			private Hashtable ParseObject()
			{
				return default;
			}

			private ArrayList ParseArray()
			{
				return default;
			}

			private object ParseValue()
			{
				return default;
			}

			private object ParseByToken(TOKEN token)
			{
				return default;
			}

			private string ParseString()
			{
				return default;
			}

			private object ParseNumber()
			{
				return default;
			}

			private void EatWhitespace()
			{
			}
		}

		private sealed class Serializer
		{
			private StringBuilder builder;

			private Serializer()
			{
			}

			public static string Serialize(object obj)
			{
				return default;
			}

			private void SerializeValue(object val)
			{
			}

			private void SerializeObject(Hashtable obj)
			{
			}

			private void SerializeArray(ArrayList anArray)
			{
			}

			private void SerializeString(string str)
			{
			}

			private void SerializeOther(object val)
			{
			}
		}

		public static object Deserialize(string json)
		{
			return default;
		}

		public static string Serialize(object obj)
		{
			return default;
		}
	}
}
