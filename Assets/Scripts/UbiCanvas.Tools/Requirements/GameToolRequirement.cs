namespace UbiCanvas.Tools
{
	public abstract class GameToolRequirement
	{
		public abstract RequirementResult IsAvailable();

		public class RequirementResult
		{
			public RequirementResult(bool isAvailable, string requirementText)
			{
				IsAvailable = isAvailable;
				RequirementText = requirementText;
			}

			public bool IsAvailable { get; }
			public string RequirementText { get; }
		}
	}
}