namespace _12._Generic_Practice
{
	internal class Program
	{
		public static void ArrayCopy<T>(T[] source, T[] output)
		{
			for (int i = 0; i < source.Length; i++) { output[i] = source[i]; }
		}
		static void Main(string[] args)
		{
			int[] iSrc = { 1, 2, 3, 4, 5 };
			int[] iOut = new int[5];

			ArrayCopy(iSrc, iOut);

			float[] fSrc = { 1.0f, 2.0f, 3.0f, 4.0f, 5.5f };
			float[] fOut = new float[5];

			ArrayCopy(fSrc, fOut);

			char[] cSrc = { 'a', 'b', 'c', };
			char[] cOut = new char[3];

			ArrayCopy(cSrc, cOut);
		}
	}
}