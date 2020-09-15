using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_FeedbackManager_Template : CSerializable {
		public Placeholder soundDescriptors;
		public Placeholder fxDescriptors;
		public Placeholder sequencePaths;
		public StringID defaultIdentifier;
		public StringID defaultModifier;
		public StringID alwaysLoaded_ContextTag;
		public StringID alwaysLoadedExploration_ContextTag;
		public StringID alwaysLoadedBattle_ContextTag;
		public bool isPreloadAllFeedbacksEnabled;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			soundDescriptors = s.SerializeObject<Placeholder>(soundDescriptors, name: "soundDescriptors");
			fxDescriptors = s.SerializeObject<Placeholder>(fxDescriptors, name: "fxDescriptors");
			sequencePaths = s.SerializeObject<Placeholder>(sequencePaths, name: "sequencePaths");
			defaultIdentifier = s.SerializeObject<StringID>(defaultIdentifier, name: "defaultIdentifier");
			defaultModifier = s.SerializeObject<StringID>(defaultModifier, name: "defaultModifier");
			alwaysLoaded_ContextTag = s.SerializeObject<StringID>(alwaysLoaded_ContextTag, name: "alwaysLoaded_ContextTag");
			alwaysLoadedExploration_ContextTag = s.SerializeObject<StringID>(alwaysLoadedExploration_ContextTag, name: "alwaysLoadedExploration_ContextTag");
			alwaysLoadedBattle_ContextTag = s.SerializeObject<StringID>(alwaysLoadedBattle_ContextTag, name: "alwaysLoadedBattle_ContextTag");
			isPreloadAllFeedbacksEnabled = s.Serialize<bool>(isPreloadAllFeedbacksEnabled, name: "isPreloadAllFeedbacksEnabled", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0x4A67ED13;
	}
}

