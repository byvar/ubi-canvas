using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RandomAnimBankChangeComponent_Template : ActorComponent_Template {
		public CList<RandomAnimBankChangeComponent_Template.tplRandomPatchNames> PatchNameCanBeRemoved;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			PatchNameCanBeRemoved = s.SerializeObject<CList<RandomAnimBankChangeComponent_Template.tplRandomPatchNames>>(PatchNameCanBeRemoved, name: "PatchNameCanBeRemoved");
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class tplRandomPatchNames : CSerializable {
			public StringID Name;
			public float Percent;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Name = s.SerializeObject<StringID>(Name, name: "Name");
				Percent = s.Serialize<float>(Percent, name: "Percent");
			}
		}
		public override uint? ClassCRC => 0xFB363E88;
	}
}

