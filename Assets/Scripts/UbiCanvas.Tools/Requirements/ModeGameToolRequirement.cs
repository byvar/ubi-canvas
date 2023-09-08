using System;
using System.Linq;
using UbiArt;

namespace UbiCanvas.Tools
{
	public class ModeGameToolRequirement : GameToolRequirement
	{
		public ModeGameToolRequirement(params Mode[] modes)
		{
			Modes = modes;
			RequirementText = $"Mode has to be one of the following: {String.Join(", ", modes)}";
		}

		private string RequirementText { get; }
		public Mode[] Modes { get; }

		public override RequirementResult IsAvailable()
		{
			return new RequirementResult(Modes.Contains(UnitySettings.GameMode), RequirementText);
		}
	}
}