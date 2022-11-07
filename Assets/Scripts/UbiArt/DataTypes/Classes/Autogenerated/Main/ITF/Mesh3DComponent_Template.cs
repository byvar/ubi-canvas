namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class Mesh3DComponent_Template : GraphicComponent_Template {
		public AABB forcedAABB;
		public CListO<GFXMaterialSerializable> materialList;
		public Path mesh3D;
		public CListO<Path> mesh3Dlist;
		public Path skeleton3D;
		public Path animation3D;
		public Color defaultColor;
		public CListO<Path> animation3Dlist;
		public Animation3DTree_Template animationTree;
		public Animation3DSet_Template animationList;
		public CListO<InputDesc> inputs;
		public StringID animationNode;
		public bool force2DRender;
		public bool renderToTexture;
		public AABB impostorAABB;
		public StringID impostorBoneName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.VH) {
				forcedAABB = s.SerializeObject<AABB>(forcedAABB, name: "forcedAABB");
				materialList = s.SerializeObject<CListO<GFXMaterialSerializable>>(materialList, name: "materialList");
				mesh3D = s.SerializeObject<Path>(mesh3D, name: "mesh3D");
				mesh3Dlist = s.SerializeObject<CListO<Path>>(mesh3Dlist, name: "mesh3Dlist");
				skeleton3D = s.SerializeObject<Path>(skeleton3D, name: "skeleton3D");
				animation3D = s.SerializeObject<Path>(animation3D, name: "animation3D");
				defaultColor = s.SerializeObject<Color>(defaultColor, name: "defaultColor");
				animation3Dlist = s.SerializeObject<CListO<Path>>(animation3Dlist, name: "animation3Dlist");
				animationTree = s.SerializeObject<Animation3DTree_Template>(animationTree, name: "animationTree");
				animationList = s.SerializeObject<Animation3DSet_Template>(animationList, name: "animationList");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
				force2DRender = s.Serialize<bool>(force2DRender, name: "force2DRender");
				animationNode = s.SerializeObject<StringID>(animationNode, name: "animationNode");
			} else if (s.Settings.game == Settings.Game.COL) {
				forcedAABB = s.SerializeObject<AABB>(forcedAABB, name: "forcedAABB");
				materialList = s.SerializeObject<CListO<GFXMaterialSerializable>>(materialList, name: "materialList");
				mesh3D = s.SerializeObject<Path>(mesh3D, name: "mesh3D");
				mesh3Dlist = s.SerializeObject<CListO<Path>>(mesh3Dlist, name: "mesh3Dlist");
				skeleton3D = s.SerializeObject<Path>(skeleton3D, name: "skeleton3D");
				animation3D = s.SerializeObject<Path>(animation3D, name: "animation3D");
				defaultColor = s.SerializeObject<Color>(defaultColor, name: "defaultColor");
				animation3Dlist = s.SerializeObject<CListO<Path>>(animation3Dlist, name: "animation3Dlist");
				animationTree = s.SerializeObject<Animation3DTree_Template>(animationTree, name: "animationTree");
				animationList = s.SerializeObject<Animation3DSet_Template>(animationList, name: "animationList");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
				force2DRender = s.Serialize<bool>(force2DRender, name: "force2DRender", options: CSerializerObject.Options.BoolAsByte);
				animationNode = s.SerializeObject<StringID>(animationNode, name: "animationNode");
				renderToTexture = s.Serialize<bool>(renderToTexture, name: "renderToTexture", options: CSerializerObject.Options.BoolAsByte);
				impostorAABB = s.SerializeObject<AABB>(impostorAABB, name: "impostorAABB");
				impostorBoneName = s.SerializeObject<StringID>(impostorBoneName, name: "impostorBoneName");
			} else {
				forcedAABB = s.SerializeObject<AABB>(forcedAABB, name: "forcedAABB");
				materialList = s.SerializeObject<CListO<GFXMaterialSerializable>>(materialList, name: "materialList");
				mesh3D = s.SerializeObject<Path>(mesh3D, name: "mesh3D");
				mesh3Dlist = s.SerializeObject<CListO<Path>>(mesh3Dlist, name: "mesh3Dlist");
				skeleton3D = s.SerializeObject<Path>(skeleton3D, name: "skeleton3D");
				animation3D = s.SerializeObject<Path>(animation3D, name: "animation3D");
				defaultColor = s.SerializeObject<Color>(defaultColor, name: "defaultColor");
				animation3Dlist = s.SerializeObject<CListO<Path>>(animation3Dlist, name: "animation3Dlist");
				animationTree = s.SerializeObject<Animation3DTree_Template>(animationTree, name: "animationTree");
				animationList = s.SerializeObject<Animation3DSet_Template>(animationList, name: "animationList");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
				animationNode = s.SerializeObject<StringID>(animationNode, name: "animationNode");
			}
		}
		public override uint? ClassCRC => 0x68ED319A;
	}
}

