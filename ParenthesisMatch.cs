namespace ParenthesisMatch
{
	public class ParenthesisMatch
	{
		public char FirstValuetoCompare { get; set; }
		public char SecondValuetoCompare { get; set; }


		public bool CompareifParenthesisareMatching(string inputValue)
		{
			int opencount = 0, closecount = 0;

			for (var i = 0; i < inputValue.Length; i++)
			{
				if (inputValue[i] == FirstValuetoCompare)
					opencount++;

				if (inputValue[i] == SecondValuetoCompare)
					closecount++;                                                                                                                                                                                                                                                                                     
			}

			if (opencount == closecount) return true;
			                                               
			return false;
		}

		
	}
}