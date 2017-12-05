namespace ParenthesisMatch
{
	public class ParenthesisMatch
	{
		public char FirstValuetoCompare { get; set; }
		public char SecondValuetoCompare { get; set; }


		public bool CompareifParenthesisareMatching(string inputValue)
		{
			int opencount = 0, closecount = 0;

			if (string.IsNullOrEmpty(inputValue)) return false;

			if (inputValue.Contains("(") && inputValue.Contains(")"))

			{
				for (var i = 0; i < inputValue.Length; i++)
				{
					if (inputValue[i] == FirstValuetoCompare)
						opencount++;

					if (inputValue[i] == SecondValuetoCompare)
						closecount++;

					if (closecount > opencount) return false;
				}

				if (opencount == closecount) return true;
			}

			return false;
		}
	}
}