using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionActionActivateActor_Template : CSerializable {
		[Serialize("Id"      )] public Placeholder Id;
		[Serialize("activate")] public int activate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Id));
			SerializeField(s, nameof(activate));
		}
		public override uint? ClassCRC => 0xF694C902;
	}
}

