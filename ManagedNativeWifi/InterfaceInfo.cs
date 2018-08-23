using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ManagedNativeWifi.Win32.NativeMethod;

namespace ManagedNativeWifi
{
	/// <summary>
	/// Wireless interface information
	/// </summary>
	public class InterfaceInfo
	{
		/// <summary>
		/// Interface ID
		/// </summary>
		public Guid Id { get; }

		/// <summary>
		/// Interface description
		/// </summary>
		public string Description { get; }

		/// <summary>
		/// Interface state
		/// </summary>
		public InterfaceState State { get; }

		/// <summary>
		/// Constructor
		/// </summary>
		public InterfaceInfo(Guid id, string description, InterfaceState state)
		{
			this.Id = id;
			this.Description = description;
			this.State = state;
		}

		internal InterfaceInfo(WLAN_INTERFACE_INFO info)
		{
			Id = info.InterfaceGuid;
			Description = info.strInterfaceDescription;
			State = InterfaceStateConverter.Convert(info.isState);
		}
	}
}