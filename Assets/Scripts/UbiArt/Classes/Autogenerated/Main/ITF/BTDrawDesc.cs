using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class BTDrawDesc : CSerializable {
		[Serialize("StepX"         )] public float StepX;
		[Serialize("StepY"         )] public float StepY;
		[Serialize("FirstLefPosX"  )] public float FirstLefPosX;
		[Serialize("nodeRaduis"    )] public float nodeRaduis;
		[Serialize("DetailRootPosX")] public float DetailRootPosX;
		[Serialize("DetailRootPosY")] public float DetailRootPosY;
		[Serialize("DisplayDetail" )] public bool DisplayDetail;
		[Serialize("NodeTitleColor")] public Color NodeTitleColor;
		[Serialize("ClampTitle"    )] public bool ClampTitle;
		[Serialize("NodeTitle"     )] public NODE_TITLE NodeTitle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StepX));
			SerializeField(s, nameof(StepY));
			SerializeField(s, nameof(FirstLefPosX));
			SerializeField(s, nameof(nodeRaduis));
			SerializeField(s, nameof(DetailRootPosX));
			SerializeField(s, nameof(DetailRootPosY));
			SerializeField(s, nameof(DisplayDetail));
			SerializeField(s, nameof(NodeTitleColor));
			SerializeField(s, nameof(ClampTitle));
			SerializeField(s, nameof(NodeTitle));
		}
		public enum NODE_TITLE {
			[Serialize("NODE_TITLE_None"     )] None = 0,
			[Serialize("NODE_TITLE_NodeName" )] NodeName = 1,
			[Serialize("NODE_TITLE_ClassName")] ClassName = 2,
		}
	}
}

