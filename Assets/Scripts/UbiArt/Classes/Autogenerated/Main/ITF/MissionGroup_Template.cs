using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionGroup_Template : CSerializable {
		[Serialize("cheatMapPath"      )] public PathRef cheatMapPath;
		[Serialize("concurrent"        )] public bool concurrent;
		[Serialize("pickOneAfterBattle")] public bool pickOneAfterBattle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(cheatMapPath));
			SerializeField(s, nameof(concurrent), boolAsByte: true);
			SerializeField(s, nameof(pickOneAfterBattle), boolAsByte: true);
		}
		public override uint? ClassCRC => 0xC024AC8B;
	}
}

