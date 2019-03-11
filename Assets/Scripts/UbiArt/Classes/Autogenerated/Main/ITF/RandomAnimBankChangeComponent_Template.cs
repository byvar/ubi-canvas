using UnityEngine;

namespace UbiArt.ITF {
	public partial class RandomAnimBankChangeComponent_Template : ActorComponent_Template {
		[Serialize("PatchNameCanBeRemoved")] public CList<RandomAnimBankChangeComponent_Template.tplRandomPatchNames> PatchNameCanBeRemoved;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(PatchNameCanBeRemoved));
		}
		public partial class tplRandomPatchNames : CSerializable {
			[Serialize("Name"   )] public StringID Name;
			[Serialize("Percent")] public float Percent;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(Name));
				SerializeField(s, nameof(Percent));
			}
		}
		public override uint? ClassCRC => 0xFB363E88;
	}
}

