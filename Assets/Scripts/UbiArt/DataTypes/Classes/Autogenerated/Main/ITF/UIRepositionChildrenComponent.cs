namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class UIRepositionChildrenComponent : UIItem {
		public int spaceBetweenChildren;
		public int verticalOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			spaceBetweenChildren = s.Serialize<int>(spaceBetweenChildren, name: "spaceBetweenChildren");
			verticalOffset = s.Serialize<int>(verticalOffset, name: "verticalOffset");
		}
		public override uint? ClassCRC => 0xB4A5EA86;
	}
}

