using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_FeedbackManager_Template : CSerializable {
		[Serialize("soundDescriptors"                  )] public Placeholder soundDescriptors;
		[Serialize("fxDescriptors"                     )] public Placeholder fxDescriptors;
		[Serialize("sequencePaths"                     )] public Placeholder sequencePaths;
		[Serialize("defaultIdentifier"                 )] public StringID defaultIdentifier;
		[Serialize("defaultModifier"                   )] public StringID defaultModifier;
		[Serialize("alwaysLoaded_ContextTag"           )] public StringID alwaysLoaded_ContextTag;
		[Serialize("alwaysLoadedExploration_ContextTag")] public StringID alwaysLoadedExploration_ContextTag;
		[Serialize("alwaysLoadedBattle_ContextTag"     )] public StringID alwaysLoadedBattle_ContextTag;
		[Serialize("isPreloadAllFeedbacksEnabled"      )] public bool isPreloadAllFeedbacksEnabled;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(soundDescriptors));
			SerializeField(s, nameof(fxDescriptors));
			SerializeField(s, nameof(sequencePaths));
			SerializeField(s, nameof(defaultIdentifier));
			SerializeField(s, nameof(defaultModifier));
			SerializeField(s, nameof(alwaysLoaded_ContextTag));
			SerializeField(s, nameof(alwaysLoadedExploration_ContextTag));
			SerializeField(s, nameof(alwaysLoadedBattle_ContextTag));
			SerializeField(s, nameof(isPreloadAllFeedbacksEnabled), boolAsByte: true);
		}
		public override uint? ClassCRC => 0x4A67ED13;
	}
}

