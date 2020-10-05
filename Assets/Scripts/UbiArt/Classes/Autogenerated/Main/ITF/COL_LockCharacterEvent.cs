using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LockCharacterEvent : CSerializable {
		public uint sender;
		public bool _lock;
		public StringID characterID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sender = s.Serialize<uint>(sender, name: "sender");
			_lock = s.Serialize<bool>(_lock, name: "lock", options: CSerializerObject.Options.BoolAsByte);
			characterID = s.SerializeObject<StringID>(characterID, name: "characterID");
		}
		public override uint? ClassCRC => 0x81DA3C2A;
	}
}

