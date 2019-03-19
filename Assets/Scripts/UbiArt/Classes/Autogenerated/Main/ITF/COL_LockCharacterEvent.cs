using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LockCharacterEvent : CSerializable {
		[Serialize("sender"     )] public uint sender;
		[Serialize("lock"       )] public bool _lock;
		[Serialize("characterID")] public StringID characterID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
			SerializeField(s, nameof(_lock), boolAsByte: true);
			SerializeField(s, nameof(characterID));
		}
		public override uint? ClassCRC => 0x9043302F;
	}
}

