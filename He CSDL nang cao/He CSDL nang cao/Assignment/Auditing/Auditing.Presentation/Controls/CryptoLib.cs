using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Auditing.Presentation.Controls
{
	public class CryptoLib
	{
		public static string SymmetricEncrypt(string source, byte[] key, byte[] iv)
		{
			return SymmetricEncrypt(source, key, iv, Encoding.Unicode);
		}
		public static string SymmetricEncrypt(string source, byte[] key, byte[] iv, Encoding encoding)
		{
			byte[] data = encoding.GetBytes(source);
			byte[] result = SymmetricEncrypt(data, key, iv);
			return result != null ? encoding.GetString(result) : "";
		}
		public static byte[] SymmetricEncrypt(byte[] source, byte[] key, byte[] iv)
		{
			byte[] result = null;

			try
			{
				Stream sourceStream = new MemoryStream(source);
				Stream destStream = new MemoryStream();
				Queue<byte> outputData = new Queue<byte>();

				using (SymmetricAlgorithm alg = SymmetricAlgorithm.Create("3DES"))
				{
					alg.Key = key;
					alg.IV = iv;
					CryptoStream cryptoStream = new CryptoStream(sourceStream, alg.CreateEncryptor(), CryptoStreamMode.Read);

					int i, bufferLength;
					byte[] buffer = new byte[1024];
					do
					{
						bufferLength = cryptoStream.Read(buffer, 0, 1024);
						destStream.Write(buffer, 0, bufferLength);
						for (i = 0; i < bufferLength; i++)
							outputData.Enqueue(buffer[i]);
					} while (bufferLength > 0);

					cryptoStream.Clear();
					cryptoStream.Close();
				}

				result = outputData.ToArray();
			}
			catch { }

			return result;
		}

		public static string SymmetricDecrypt(string source, byte[] key, byte[] iv)
		{
			return SymmetricDecrypt(source, key, iv, Encoding.Unicode);
		}
		public static string SymmetricDecrypt(string source, byte[] key, byte[] iv, Encoding encoding)
		{
			byte[] data = encoding.GetBytes(source);
			byte[] result = SymmetricDecrypt(data, key, iv);
			return result != null ? encoding.GetString(result) : "";
		}
		public static byte[] SymmetricDecrypt(byte[] source, byte[] key, byte[] iv)
		{
			Stream sourceStream = new MemoryStream(source);
			Stream destStream = new MemoryStream();
			byte[] result;
			try
			{
				using (SymmetricAlgorithm alg = SymmetricAlgorithm.Create("3DES"))
				{
					alg.Key = key;
					alg.IV = iv;
					CryptoStream cryptoStream = new CryptoStream(destStream, alg.CreateDecryptor(), CryptoStreamMode.Write);

					int bufferLength;
					byte[] buffer = new byte[1024];
					do
					{
						bufferLength = sourceStream.Read(buffer, 0, 1024);
						cryptoStream.Write(buffer, 0, bufferLength);
					} while (bufferLength > 0);
					cryptoStream.FlushFinalBlock();

					destStream.Position = 0;
					result = new byte[destStream.Length];
					destStream.Read(result, 0, result.Length);

					cryptoStream.Clear();
					cryptoStream.Close();
				}
			}
			catch
			{
				result = null;
			}

			return result;
		}
	}
}