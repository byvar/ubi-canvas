using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class BTDrawDesc : CSerializable {
		public float StepX;
		public float StepY;
		public float FirstLefPosX;
		public float nodeRaduis;
		public float DetailRootPosX;
		public float DetailRootPosY;
		public bool DisplayDetail;
		public Color NodeTitleColor;
		public bool ClampTitle;
		public NODE_TITLE NodeTitle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StepX = s.Serialize<float>(StepX, name: "StepX");
			StepY = s.Serialize<float>(StepY, name: "StepY");
			FirstLefPosX = s.Serialize<float>(FirstLefPosX, name: "FirstLefPosX");
			nodeRaduis = s.Serialize<float>(nodeRaduis, name: "nodeRaduis");
			DetailRootPosX = s.Serialize<float>(DetailRootPosX, name: "DetailRootPosX");
			DetailRootPosY = s.Serialize<float>(DetailRootPosY, name: "DetailRootPosY");
			DisplayDetail = s.Serialize<bool>(DisplayDetail, name: "DisplayDetail");
			NodeTitleColor = s.SerializeObject<Color>(NodeTitleColor, name: "NodeTitleColor");
			ClampTitle = s.Serialize<bool>(ClampTitle, name: "ClampTitle");
			NodeTitle = s.Serialize<NODE_TITLE>(NodeTitle, name: "NodeTitle");
		}
		public enum NODE_TITLE {
			[Serialize("NODE_TITLE_None"     )] None = 0,
			[Serialize("NODE_TITLE_NodeName" )] NodeName = 1,
			[Serialize("NODE_TITLE_ClassName")] ClassName = 2,
		}
	}
}

