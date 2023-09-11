namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BossOceanAIComponent : ActorComponent {
		public CListO<RO2_BossOceanAIComponent.Sequence> sequences;
		public ObjectPath finalCinematic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				sequences = s.SerializeObject<CListO<RO2_BossOceanAIComponent.Sequence>>(sequences, name: "sequences");
				finalCinematic = s.SerializeObject<ObjectPath>(finalCinematic, name: "finalCinematic");
			}
		}
		[Games(GameFlags.RA)]
		public partial class Sequence : CSerializable {
			public StringID tweenSet;
			public StringID buboId;
			public ObjectPath objectToTriggerOnEnter;
			public ObjectPath objectToTriggerOnExit;
			public CArrayO<ObjectPath> missileRegions;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				tweenSet = s.SerializeObject<StringID>(tweenSet, name: "tweenSet");
				buboId = s.SerializeObject<StringID>(buboId, name: "buboId");
				objectToTriggerOnEnter = s.SerializeObject<ObjectPath>(objectToTriggerOnEnter, name: "objectToTriggerOnEnter");
				objectToTriggerOnExit = s.SerializeObject<ObjectPath>(objectToTriggerOnExit, name: "objectToTriggerOnExit");
				missileRegions = s.SerializeObject<CArrayO<ObjectPath>>(missileRegions, name: "missileRegions");
			}
		}
		public override uint? ClassCRC => 0x872E7CD7;
	}
}

