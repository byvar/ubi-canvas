using UnityEngine;

namespace UbiArt.ITF {
	public partial class BreakableAIComponent_Template : AIComponent_Template {
		[Serialize("crushAttackDamage"      )] public uint crushAttackDamage;
		[Serialize("frontDamage"            )] public uint frontDamage;
		[Serialize("backDamage"             )] public uint backDamage;
		[Serialize("hitAngleOffset"         )] public Angle hitAngleOffset;
		[Serialize("hitAngleMinIncidence"   )] public Angle hitAngleMinIncidence;
		[Serialize("restoreAnim"            )] public StringID restoreAnim;
		[Serialize("checkHitSenderDirection")] public bool checkHitSenderDirection;
		[Serialize("destructionStages"      )] public CList<BreakableAIComponent_Template.DestructionStage> destructionStages;
		[Serialize("openAnim"               )] public StringID openAnim;
		[Serialize("openAnimReverse"        )] public StringID openAnimReverse;
		[Serialize("resetOnCheckpoint"      )] public bool resetOnCheckpoint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(crushAttackDamage));
			SerializeField(s, nameof(frontDamage));
			SerializeField(s, nameof(backDamage));
			SerializeField(s, nameof(hitAngleOffset));
			SerializeField(s, nameof(hitAngleMinIncidence));
			SerializeField(s, nameof(restoreAnim));
			SerializeField(s, nameof(checkHitSenderDirection));
			SerializeField(s, nameof(destructionStages));
			SerializeField(s, nameof(openAnim));
			SerializeField(s, nameof(openAnimReverse));
			SerializeField(s, nameof(resetOnCheckpoint));
		}
		public partial class DestructionStage : CSerializable {
			[Serialize("rumble"        )] public StringID rumble;
			[Serialize("destroy"       )] public StringID destroy;
			[Serialize("destroyReverse")] public StringID destroyReverse;
			[Serialize("stand"         )] public StringID stand;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(rumble));
				SerializeField(s, nameof(destroy));
				SerializeField(s, nameof(destroyReverse));
				SerializeField(s, nameof(stand));
			}
		}
		public override uint? ClassCRC => 0xE32BD872;
	}
}

