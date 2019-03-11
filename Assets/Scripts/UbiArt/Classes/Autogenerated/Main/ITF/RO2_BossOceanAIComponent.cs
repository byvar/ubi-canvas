using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BossOceanAIComponent : ActorComponent {
		[Serialize("sequences"     )] public CList<RO2_BossOceanAIComponent.Sequence> sequences;
		[Serialize("finalCinematic")] public ObjectPath finalCinematic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(sequences));
				SerializeField(s, nameof(finalCinematic));
			}
		}
		public partial class Sequence : CSerializable {
			[Serialize("tweenSet"              )] public StringID tweenSet;
			[Serialize("buboId"                )] public StringID buboId;
			[Serialize("objectToTriggerOnEnter")] public ObjectPath objectToTriggerOnEnter;
			[Serialize("objectToTriggerOnExit" )] public ObjectPath objectToTriggerOnExit;
			[Serialize("missileRegions"        )] public CArray<ObjectPath> missileRegions;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(tweenSet));
				SerializeField(s, nameof(buboId));
				SerializeField(s, nameof(objectToTriggerOnEnter));
				SerializeField(s, nameof(objectToTriggerOnExit));
				SerializeField(s, nameof(missileRegions));
			}
		}
		public override uint? ClassCRC => 0x872E7CD7;
	}
}

