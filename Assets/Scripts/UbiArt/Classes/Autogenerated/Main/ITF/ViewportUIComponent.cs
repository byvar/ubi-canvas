using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class ViewportUIComponent : ActorComponent {
		[Serialize("view"                      )] public View view;
		[Serialize("active"                    )] public bool active;
		[Serialize("visibilityRequiredFlags"   )] public uint visibilityRequiredFlags;
		[Serialize("visibilityRejectFlags"     )] public uint visibilityRejectFlags;
		[Serialize("focale"                    )] public float focale;
		[Serialize("farPlane"                  )] public float farPlane;
		[Serialize("viewportDefinitionLeft"    )] public float viewportDefinitionLeft;
		[Serialize("viewportDefinitionRight"   )] public float viewportDefinitionRight;
		[Serialize("viewportDefinitionTop"     )] public float viewportDefinitionTop;
		[Serialize("viewportDefinitionBottom"  )] public float viewportDefinitionBottom;
		[Serialize("viewportPosition"          )] public Vector2 viewportPosition;
		[Serialize("viewportSize"              )] public Vector2 viewportSize;
		[Serialize("viewportRotation"          )] public float viewportRotation;
		[Serialize("frameTexturePath"          )] public Path frameTexturePath;
		[Serialize("frameShiftOutLeft"         )] public int frameShiftOutLeft;
		[Serialize("frameShiftOutTop"          )] public int frameShiftOutTop;
		[Serialize("frameShiftOutRight"        )] public int frameShiftOutRight;
		[Serialize("frameShiftOutBottom"       )] public int frameShiftOutBottom;
		[Serialize("frameSizeLeft"             )] public int frameSizeLeft;
		[Serialize("frameSizeTop"              )] public int frameSizeTop;
		[Serialize("frameSizeRight"            )] public int frameSizeRight;
		[Serialize("frameSizeBottom"           )] public int frameSizeBottom;
		[Serialize("zOrder"                    )] public float zOrder;
		[Serialize("ZPassOverride"             )] public GFX_VIEW_ZPASS ZPassOverride;
		[Serialize("updateFrustumEnlargeRange" )] public float updateFrustumEnlargeRange;
		[Serialize("loadingFrustumEnlargeRange")] public float loadingFrustumEnlargeRange;
		[Serialize("parentViewName"            )] public string parentViewName;
		[Serialize("clearViewport"             )] public bool clearViewport;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(view));
			SerializeField(s, nameof(active));
			SerializeField(s, nameof(visibilityRequiredFlags));
			SerializeField(s, nameof(visibilityRejectFlags));
			SerializeField(s, nameof(focale));
			SerializeField(s, nameof(farPlane));
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(viewportDefinitionLeft));
				SerializeField(s, nameof(viewportDefinitionRight));
				SerializeField(s, nameof(viewportDefinitionTop));
				SerializeField(s, nameof(viewportDefinitionBottom));
			}
			SerializeField(s, nameof(viewportPosition));
			SerializeField(s, nameof(viewportSize));
			SerializeField(s, nameof(viewportRotation));
			SerializeField(s, nameof(frameTexturePath));
			SerializeField(s, nameof(frameShiftOutLeft));
			SerializeField(s, nameof(frameShiftOutTop));
			SerializeField(s, nameof(frameShiftOutRight));
			SerializeField(s, nameof(frameShiftOutBottom));
			SerializeField(s, nameof(frameSizeLeft));
			SerializeField(s, nameof(frameSizeTop));
			SerializeField(s, nameof(frameSizeRight));
			SerializeField(s, nameof(frameSizeBottom));
			SerializeField(s, nameof(zOrder));
			SerializeField(s, nameof(ZPassOverride));
			SerializeField(s, nameof(updateFrustumEnlargeRange));
			SerializeField(s, nameof(loadingFrustumEnlargeRange));
			SerializeField(s, nameof(parentViewName));
			SerializeField(s, nameof(clearViewport));
		}
		public enum View {
			[Serialize("View::None"            )] None = 0,
			[Serialize("View::Main"            )] Main = 1,
			[Serialize("View::Remote"          )] Remote = 2,
			[Serialize("View::MainAndRemote"   )] MainAndRemote = 3,
			[Serialize("View::MainOnly"        )] MainOnly = 4,
			[Serialize("View::RemoteOnly"      )] RemoteOnly = 5,
			[Serialize("View::RemoteAsMainOnly")] RemoteAsMainOnly = 6,
			[Serialize("View::All"             )] All = -1,
		}
		public enum GFX_VIEW_ZPASS {
			[Serialize("GFX_VIEW_ZPASS_DEFAULT"        )] DEFAULT = 0,
			[Serialize("GFX_VIEW_ZPASS_FORCE_USE_ZPASS")] FORCE_USE_ZPASS = 1,
			[Serialize("GFX_VIEW_ZPASS_FORCE_NO_ZPASS" )] FORCE_NO_ZPASS = 2,
		}
		public override uint? ClassCRC => 0x6990834C;
	}
}

