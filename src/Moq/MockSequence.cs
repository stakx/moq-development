// Copyright (c) 2007, Clarius Consulting, Manas Technology Solutions, InSTEDD.
// All rights reserved. Licensed under the BSD 3-Clause License; see License.txt.

using System.ComponentModel;

using Moq.Language;
using Moq.Language.Flow;

namespace Moq
{
	/// <summary>
	/// Helper class to setup a full trace between many mocks
	/// </summary>
	public class MockSequence
	{
		int sequenceStep;
		int sequenceLength;

		/// <summary>
		/// Initialize a trace setup
		/// </summary>
		public MockSequence()
		{
			sequenceLength = 0;
			sequenceStep = 0;
		}

		/// <summary>
		/// Allow sequence to be repeated
		/// </summary>
		public bool Cyclic { get; set; }

		private void NextStep()
		{
			sequenceStep++;
			if (Cyclic)
				sequenceStep = sequenceStep % sequenceLength;
		}

		internal ISetupConditionResult<TMock> For<TMock>(Mock<TMock> mock)
			where TMock : class
		{
			var expectationPosition = sequenceLength++;

			return new WhenPhrase<TMock>(mock, new Condition(
				condition: () => expectationPosition == sequenceStep,
				success: NextStep));
		}
	}
}
