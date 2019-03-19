using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_380_sub_AE7010 : CSerializable {
		[Serialize("faction"               )] public uint faction;
		[Serialize("squashDeathPenetration")] public float squashDeathPenetration;
		[Serialize("timeFight"             )] public float timeFight;
		[Serialize("disabledPhys"          )] public int disabledPhys;
		[Serialize("withShield"            )] public int withShield;
		[Serialize("colShield"             )] public StringID colShield;
		[Serialize("colShield2"            )] public StringID colShield2;
		[Serialize("timeBlockingContact"   )] public float timeBlockingContact;
		[Serialize("withStilts"            )] public int withStilts;
		[Serialize("colStilt01"            )] public StringID colStilt01;
		[Serialize("colStilt02"            )] public StringID colStilt02;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(squashDeathPenetration));
			SerializeField(s, nameof(timeFight));
			SerializeField(s, nameof(disabledPhys));
			SerializeField(s, nameof(withShield));
			SerializeField(s, nameof(colShield));
			SerializeField(s, nameof(colShield2));
			SerializeField(s, nameof(timeBlockingContact));
			SerializeField(s, nameof(withStilts));
			SerializeField(s, nameof(colStilt01));
			SerializeField(s, nameof(colStilt02));
		}
		public override uint? ClassCRC => 0x7E98C9A8;
	}
}

