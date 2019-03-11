using UnityEngine;

namespace UbiArt.online {
	public partial class RequestOptions : CSerializable {
		[Serialize("connectModule"      )] public bool connectModule;
		[Serialize("retryIfDisconnected")] public bool retryIfDisconnected;
		[Serialize("maxAutoRetry"       )] public uint maxAutoRetry;
		[Serialize("autoRetryDelay"     )] public float autoRetryDelay;
		[Serialize("notifyErrorRetry"   )] public bool notifyErrorRetry;
		[Serialize("inProgressPopup"    )] public RequestOptions.PopupOptions inProgressPopup;
		[Serialize("errorPopup"         )] public RequestOptions.ErrorPopupOptions errorPopup;
		[Serialize("errorRetryPopup"    )] public RequestOptions.ErrorPopupOptions errorRetryPopup;
		[Serialize("successPopup"       )] public RequestOptions.PopupOptions successPopup;
		[Serialize("silentConnection"   )] public bool silentConnection;
		[Serialize("needPid"            )] public bool needPid;
		[Serialize("timeout"            )] public float timeout;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(connectModule));
			SerializeField(s, nameof(retryIfDisconnected));
			SerializeField(s, nameof(maxAutoRetry));
			SerializeField(s, nameof(autoRetryDelay));
			SerializeField(s, nameof(notifyErrorRetry));
			SerializeField(s, nameof(inProgressPopup));
			SerializeField(s, nameof(errorPopup));
			SerializeField(s, nameof(errorRetryPopup));
			SerializeField(s, nameof(successPopup));
			SerializeField(s, nameof(silentConnection));
			SerializeField(s, nameof(needPid));
			SerializeField(s, nameof(timeout));
		}
		public partial class PopupOptions : CSerializable {
			[Serialize("show"      )] public bool show;
			[Serialize("trcContext")] public Enum_trcContext trcContext;
			[Serialize("delay"     )] public float delay;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(show));
				SerializeField(s, nameof(trcContext));
				SerializeField(s, nameof(delay));
			}
			public enum Enum_trcContext {
			}
		}
		public partial class ErrorPopupOptions : CSerializable {
			[Serialize("default" )] public RequestOptions.PopupOptions _default;
			[Serialize("specific")] public CMap<Error.GameServerError, RequestOptions.PopupOptions> specific;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(_default));
				SerializeField(s, nameof(specific));
			}
		}
	}
}

