namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_AutomaticPopupSave : CSerializable {
		public online.DateTime lastShownTimestamp;
		public uint nbSessionsSinceLastShown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lastShownTimestamp = s.SerializeObject<online.DateTime>(lastShownTimestamp, name: "lastShownTimestamp");
			nbSessionsSinceLastShown = s.Serialize<uint>(nbSessionsSinceLastShown, name: "nbSessionsSinceLastShown");
		}
	}
}

