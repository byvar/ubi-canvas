namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class PetProfile : CSerializable {
		public int petModelID;
		public uint petProfileHandle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			petModelID = s.Serialize<int>(petModelID, name: "petModelID");
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				petProfileHandle = s.Serialize<uint>(petProfileHandle, name: "petProfileHandle");
			}
		}
	}
}
