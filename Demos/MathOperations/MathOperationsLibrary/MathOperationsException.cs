using System;

namespace TaleLearnCode.MathOperationsLibrary
{

	public class MathOperationsException : Exception
	{
		public MathOperationsException() { }

		public MathOperationsException(string message) : base(message) { }

		public MathOperationsException(string message, Exception innerException)
				: base(message, innerException) { }
	}
}