using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_137_sub_737400 : CSerializable {
		[Serialize("upMargin"      )] public float upMargin;
		[Serialize("rightMargin"   )] public float rightMargin;
		[Serialize("appear"        )] public StringID appear;
		[Serialize("prisonerAppear")] public StringID prisonerAppear;
		[Serialize("stand"         )] public StringID stand;
		[Serialize("disappear"     )] public StringID disappear;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(upMargin));
			SerializeField(s, nameof(rightMargin));
			SerializeField(s, nameof(appear));
			SerializeField(s, nameof(prisonerAppear));
			SerializeField(s, nameof(stand));
			SerializeField(s, nameof(disappear));
		}
		public override uint? ClassCRC => 0x222209E0;
	}
}

