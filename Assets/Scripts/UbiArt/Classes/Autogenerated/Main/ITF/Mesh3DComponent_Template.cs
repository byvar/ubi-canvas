using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class Mesh3DComponent_Template : GraphicComponent_Template {
		[Serialize("forcedAABB"      )] public AABB forcedAABB;
		[Serialize("materialList"    )] public CList<GFXMaterialSerializable> materialList;
		[Serialize("mesh3D"          )] public Path mesh3D;
		[Serialize("mesh3Dlist"      )] public CList<Path> mesh3Dlist;
		[Serialize("skeleton3D"      )] public Path skeleton3D;
		[Serialize("animation3D"     )] public Path animation3D;
		[Serialize("defaultColor"    )] public Color defaultColor;
		[Serialize("animation3Dlist" )] public CList<Path> animation3Dlist;
		[Serialize("animationTree"   )] public Animation3DTree_Template animationTree;
		[Serialize("animationList"   )] public Animation3DSet_Template animationList;
		[Serialize("inputs"          )] public CList<InputDesc> inputs;
		[Serialize("animationNode"   )] public StringID animationNode;
		[Serialize("force2DRender"   )] public int force2DRender;
		[Serialize("force2DRender"   )] public bool force2DRender;
		[Serialize("renderToTexture" )] public bool renderToTexture;
		[Serialize("impostorAABB"    )] public Placeholder impostorAABB;
		[Serialize("impostorBoneName")] public StringID impostorBoneName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(forcedAABB));
				SerializeField(s, nameof(materialList));
				SerializeField(s, nameof(mesh3D));
				SerializeField(s, nameof(mesh3Dlist));
				SerializeField(s, nameof(skeleton3D));
				SerializeField(s, nameof(animation3D));
				SerializeField(s, nameof(defaultColor));
				SerializeField(s, nameof(animation3Dlist));
				SerializeField(s, nameof(animationTree));
				SerializeField(s, nameof(animationList));
				SerializeField(s, nameof(inputs));
				SerializeField(s, nameof(force2DRender));
				SerializeField(s, nameof(animationNode));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(forcedAABB));
				SerializeField(s, nameof(mesh3D));
				SerializeField(s, nameof(mesh3Dlist));
				SerializeField(s, nameof(skeleton3D));
				SerializeField(s, nameof(animation3D));
				SerializeField(s, nameof(defaultColor));
				SerializeField(s, nameof(animation3Dlist));
				SerializeField(s, nameof(force2DRender), boolAsByte: true);
				SerializeField(s, nameof(animationNode));
				SerializeField(s, nameof(renderToTexture), boolAsByte: true);
				SerializeField(s, nameof(impostorAABB));
				SerializeField(s, nameof(impostorBoneName));
			} else {
				SerializeField(s, nameof(forcedAABB));
				SerializeField(s, nameof(materialList));
				SerializeField(s, nameof(mesh3D));
				SerializeField(s, nameof(mesh3Dlist));
				SerializeField(s, nameof(skeleton3D));
				SerializeField(s, nameof(animation3D));
				SerializeField(s, nameof(defaultColor));
				SerializeField(s, nameof(animation3Dlist));
				SerializeField(s, nameof(animationTree));
				SerializeField(s, nameof(animationList));
				SerializeField(s, nameof(inputs));
				SerializeField(s, nameof(animationNode));
			}
		}
		public override uint? ClassCRC => 0x68ED319A;
	}
}

