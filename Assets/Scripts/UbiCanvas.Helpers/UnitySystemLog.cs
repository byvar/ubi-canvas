using System;
using UnityEngine;
using ISystemLog = UbiArt.ISystemLog;

namespace UbiCanvas {
	public class UnitySystemLog : ISystemLog
	{
		public void Log(UbiArt.LogLevel logLevel, object log, params object[] args) {
			switch (logLevel) {
				case UbiArt.LogLevel.Error:
					Debug.LogError(String.Format(log?.ToString() ?? String.Empty, args));
					break;
				case UbiArt.LogLevel.Warning:
					Debug.LogWarning(String.Format(log?.ToString() ?? String.Empty, args));
					break;
				case UbiArt.LogLevel.Info:
					Debug.Log(String.Format(log?.ToString() ?? String.Empty, args));
					break;
			}
		}
	}
}