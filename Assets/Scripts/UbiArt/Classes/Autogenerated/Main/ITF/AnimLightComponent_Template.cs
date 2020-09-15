using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AnimLightComponent_Template : GraphicComponent_Template {
		[Serialize("useBase"                 )] public bool useBase;
		[Serialize("smoothAnim"              )] public bool smoothAnim;
		[Serialize("blendAnimTrack"          )] public bool blendAnimTrack;
		[Serialize("canonizeTransitions"     )] public bool canonizeTransitions;
		[Serialize("defaultBlendFrames"      )] public uint defaultBlendFrames;
		[Serialize("draw2D"                  )] public uint draw2D;
		[Serialize("visualAABBanimID"        )] public StringID visualAABBanimID;
		[Serialize("animSet"                 )] public SubAnimSet_Template animSet;
		[Serialize("defaultAnimation"        )] public StringID defaultAnimation;
		[Serialize("subSkeleton"             )] public StringID subSkeleton;
		[Serialize("defaultColor"            )] public Color defaultColor;
		[Serialize("flip"                    )] public bool flip;
		[Serialize("backZOffset"             )] public float backZOffset;
		[Serialize("frontZOffset"            )] public float frontZOffset;
		[Serialize("zOrderExtract"           )] public float zOrderExtract;
		[Serialize("zAmplify"                )] public float zAmplify;
		[Serialize("restoreStateAtCheckpoint")] public bool restoreStateAtCheckpoint;
		[Serialize("disableVisiblePrediction")] public bool disableVisiblePrediction;
		[Serialize("notifyAnimUpdate"        )] public bool notifyAnimUpdate;
		[Serialize("scale"                   )] public Vec2d scale;
		[Serialize("useZOffset"              )] public bool useZOffset;
		[Serialize("allowRenderInTexture"    )] public bool allowRenderInTexture;
		[Serialize("renderInTectureSizeX"    )] public uint renderInTectureSizeX;
		[Serialize("renderInTectureSizeY"    )] public uint renderInTectureSizeY;
		[Serialize("boneList"                )] public CList<BoneMapping> boneList;
		[Serialize("animationPath"           )] public Path animationPath;
		[Serialize("isSynchronous"           )] public bool isSynchronous;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(animationPath));
				SerializeField(s, nameof(useBase));
				SerializeField(s, nameof(smoothAnim));
				SerializeField(s, nameof(canonizeTransitions));
				SerializeField(s, nameof(defaultBlendFrames));
				SerializeField(s, nameof(draw2D));
				SerializeField(s, nameof(visualAABBanimID));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(animSet));
				}
				SerializeField(s, nameof(defaultAnimation));
				SerializeField(s, nameof(defaultColor));
				SerializeField(s, nameof(flip));
				SerializeField(s, nameof(backZOffset));
				SerializeField(s, nameof(frontZOffset));
				SerializeField(s, nameof(isSynchronous));
				SerializeField(s, nameof(restoreStateAtCheckpoint));
				SerializeField(s, nameof(boneList));
				SerializeField(s, nameof(disableVisiblePrediction));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(useBase));
				SerializeField(s, nameof(smoothAnim));
				SerializeField(s, nameof(canonizeTransitions));
				SerializeField(s, nameof(defaultBlendFrames));
				SerializeField(s, nameof(draw2D));
				SerializeField(s, nameof(visualAABBanimID));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(animSet));
				}
				SerializeField(s, nameof(defaultAnimation));
				SerializeField(s, nameof(subSkeleton));
				SerializeField(s, nameof(defaultColor));
				SerializeField(s, nameof(flip));
				SerializeField(s, nameof(backZOffset));
				SerializeField(s, nameof(frontZOffset));
				SerializeField(s, nameof(zOrderExtract));
				SerializeField(s, nameof(zAmplify));
				SerializeField(s, nameof(isSynchronous));
				SerializeField(s, nameof(restoreStateAtCheckpoint));
				SerializeField(s, nameof(disableVisiblePrediction));
				SerializeField(s, nameof(notifyAnimUpdate));
				SerializeField(s, nameof(scale));
				SerializeField(s, nameof(useZOffset));
				SerializeField(s, nameof(boneList));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(useBase), boolAsByte: true);
				SerializeField(s, nameof(smoothAnim), boolAsByte: true);
				SerializeField(s, nameof(canonizeTransitions), boolAsByte: true);
				SerializeField(s, nameof(defaultBlendFrames));
				SerializeField(s, nameof(draw2D));
				SerializeField(s, nameof(visualAABBanimID));
				SerializeField(s, nameof(defaultAnimation));
				SerializeField(s, nameof(subSkeleton));
				SerializeField(s, nameof(defaultColor));
				SerializeField(s, nameof(flip), boolAsByte: true);
				SerializeField(s, nameof(backZOffset));
				SerializeField(s, nameof(frontZOffset));
				SerializeField(s, nameof(zOrderExtract));
				SerializeField(s, nameof(zAmplify));
				SerializeField(s, nameof(isSynchronous), boolAsByte: true);
				SerializeField(s, nameof(restoreStateAtCheckpoint), boolAsByte: true);
				SerializeField(s, nameof(disableVisiblePrediction), boolAsByte: true);
				SerializeField(s, nameof(notifyAnimUpdate), boolAsByte: true);
				SerializeField(s, nameof(scale));
				SerializeField(s, nameof(useZOffset), boolAsByte: true);
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(useBase));
				SerializeField(s, nameof(smoothAnim));
				SerializeField(s, nameof(canonizeTransitions));
				SerializeField(s, nameof(defaultBlendFrames));
				SerializeField(s, nameof(draw2D));
				SerializeField(s, nameof(visualAABBanimID));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(animSet));
				}
				SerializeField(s, nameof(defaultAnimation));
				SerializeField(s, nameof(subSkeleton));
				SerializeField(s, nameof(defaultColor));
				SerializeField(s, nameof(flip));
				SerializeField(s, nameof(backZOffset));
				SerializeField(s, nameof(frontZOffset));
				SerializeField(s, nameof(zOrderExtract));
				SerializeField(s, nameof(zAmplify));
				SerializeField(s, nameof(restoreStateAtCheckpoint));
				SerializeField(s, nameof(disableVisiblePrediction));
				SerializeField(s, nameof(notifyAnimUpdate));
				SerializeField(s, nameof(scale));
				SerializeField(s, nameof(useZOffset));
				SerializeField(s, nameof(allowRenderInTexture));
				SerializeField(s, nameof(renderInTectureSizeX));
				SerializeField(s, nameof(renderInTectureSizeY));
				SerializeField(s, nameof(boneList));
			} else {
				SerializeField(s, nameof(useBase));
				SerializeField(s, nameof(smoothAnim));
				SerializeField(s, nameof(blendAnimTrack));
				SerializeField(s, nameof(canonizeTransitions));
				SerializeField(s, nameof(defaultBlendFrames));
				SerializeField(s, nameof(draw2D));
				SerializeField(s, nameof(visualAABBanimID));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(animSet));
				}
				SerializeField(s, nameof(defaultAnimation));
				SerializeField(s, nameof(subSkeleton));
				SerializeField(s, nameof(defaultColor));
				SerializeField(s, nameof(flip));
				SerializeField(s, nameof(backZOffset));
				SerializeField(s, nameof(frontZOffset));
				SerializeField(s, nameof(zOrderExtract));
				SerializeField(s, nameof(zAmplify));
				SerializeField(s, nameof(restoreStateAtCheckpoint));
				SerializeField(s, nameof(disableVisiblePrediction));
				SerializeField(s, nameof(notifyAnimUpdate));
				SerializeField(s, nameof(scale));
				SerializeField(s, nameof(useZOffset));
				SerializeField(s, nameof(allowRenderInTexture));
				SerializeField(s, nameof(renderInTectureSizeX));
				SerializeField(s, nameof(renderInTectureSizeY));
				SerializeField(s, nameof(boneList));
			}
		}
		public override uint? ClassCRC => 0xA3557351;
	}
}

