﻿![Vanara](https://raw.githubusercontent.com/dahall/Vanara/master/docs/icons/VanaraHeading.png)
### **Vanara.PInvoke.IpHlpApi NuGet Package**
[![Version](https://img.shields.io/nuget/v/Vanara.PInvoke.IpHlpApi?label=NuGet&style=flat-square)](https://github.com/dahall/Vanara/releases)
[![Build status](https://img.shields.io/appveyor/build/dahall/vanara?label=AppVeyor%20build&style=flat-square)](https://ci.appveyor.com/project/dahall/vanara)

PInvoke API (methods, structures and constants) imported from Windows IpHlpApi.dll.

### **What is Vanara?**

[Vanara](https://github.com/dahall/Vanara) is a community project that contains various .NET assemblies which have P/Invoke functions, interfaces, enums and structures from Windows libraries. Each assembly is associated with one or a few tightly related libraries.

### **Issues?**

First check if it's already fixed by trying the [AppVeyor build](https://ci.appveyor.com/nuget/vanara-prerelease).
If you're still running into problems, file an [issue](https://github.com/dahall/Vanara/issues).

### **Included in Vanara.PInvoke.IpHlpApi**

Functions | Enumerations | Structures
--- | --- | ---
AddIPAddress CancelIPChangeNotify CancelMibChangeNotify2 ConvertInterfaceAliasToLuid ConvertInterfaceGuidToLuid ConvertInterfaceIndexToLuid ConvertInterfaceLuidToAlias ConvertInterfaceLuidToGuid ConvertInterfaceLuidToIndex ConvertInterfaceLuidToNameA ConvertInterfaceLuidToNameW ConvertInterfaceNameToLuidA ConvertInterfaceNameToLuidW ConvertIpv4MaskToLength ConvertLengthToIpv4Mask CreateAnycastIpAddressEntry CreateIpForwardEntry CreateIpForwardEntry2 CreateIpNetEntry CreateIpNetEntry2 CreatePersistentTcpPortReservation CreatePersistentUdpPortReservation CreateProxyArpEntry CreateSortedAddressPairs CreateUnicastIpAddressEntry DeleteAnycastIpAddressEntry DeleteIPAddress DeleteIpForwardEntry DeleteIpForwardEntry2 DeleteIpNetEntry DeleteIpNetEntry2 DeletePersistentTcpPortReservation DeletePersistentUdpPortReservation DeleteProxyArpEntry DeleteUnicastIpAddressEntry DisableMediaSense EnableRouter FlushIpNetTable FlushIpNetTable2 FlushIpPathTable FreeMibTable GetAdapterIndex GetAdapterOrderMap GetAdaptersAddresses GetAdaptersInfo GetAnycastIpAddressEntry GetAnycastIpAddressTable GetBestInterface GetBestInterfaceEx GetBestRoute GetBestRoute2 GetExtendedTcpTable GetExtendedUdpTable GetFriendlyIfIndex GetIcmpStatistics GetIcmpStatisticsEx GetIfEntry GetIfEntry2 GetIfEntry2Ex GetIfStackTable GetIfTable GetIfTable2 GetIfTable2Ex GetInterfaceActiveTimestampCapabilities GetInterfaceInfo GetInterfaceSupportedTimestampCapabilities GetInvertedIfStackTable GetIpAddrTable GetIpErrorString GetIpForwardEntry2 GetIpForwardTable GetIpForwardTable2 GetIpInterfaceEntry GetIpInterfaceTable GetIpNetEntry2 GetIpNetTable GetIpNetTable2 GetIpNetworkConnectionBandwidthEstimates GetIpPathEntry GetIpPathTable GetIpStatistics GetIpStatisticsEx GetMulticastIpAddressEntry GetMulticastIpAddressTable GetNetworkConnectivityHint GetNetworkConnectivityHintForInterface GetNetworkParams GetNumberOfInterfaces GetOwnerModuleFromPidAndInfo GetOwnerModuleFromTcp6Entry GetOwnerModuleFromTcpEntry GetOwnerModuleFromUdp6Entry GetOwnerModuleFromUdpEntry GetPerAdapterInfo GetPerTcp6ConnectionEStats GetPerTcpConnectionEStats GetRTTAndHopCount GetTcp6Table GetTcp6Table2 GetTcpStatistics GetTcpStatisticsEx GetTcpStatisticsEx2 GetTcpTable GetTcpTable2 GetTeredoPort GetUdp6Table GetUdpStatistics GetUdpStatisticsEx GetUdpStatisticsEx2 GetUdpTable GetUnicastIpAddressEntry GetUnicastIpAddressTable GetUniDirectionalAdapterInfo Icmp6CreateFile Icmp6ParseReplies Icmp6SendEcho2 IcmpCloseHandle IcmpCreateFile IcmpParseReplies IcmpSendEcho IcmpSendEcho2 IcmpSendEcho2Ex if_indextoname if_nametoindex InitializeIpForwardEntry InitializeIpInterfaceEntry InitializeUnicastIpAddressEntry IpReleaseAddress IpRenewAddress LookupPersistentTcpPortReservation LookupPersistentUdpPortReservation NotifyAddrChange NotifyIpInterfaceChange NotifyNetworkConnectivityHintChange NotifyRouteChange NotifyRouteChange2 NotifyStableUnicastIpAddressTable NotifyTeredoPortChange NotifyUnicastIpAddressChange ParseNetworkString RegisterInterfaceTimestampConfigChange ResolveIpNetEntry2 RestoreMediaSense SendARP SetCurrentThreadCompartmentId SetIfEntry SetIpForwardEntry SetIpForwardEntry2 SetIpInterfaceEntry SetIpNetEntry SetIpNetEntry2 SetIpStatistics SetIpStatisticsEx SetIpTTL SetNetworkInformation SetPerTcp6ConnectionEStats SetPerTcpConnectionEStats SetSessionCompartmentId SetTcpEntry SetUnicastIpAddressEntry UnenableRouter UnregisterInterfaceTimestampConfigChange  | IF_ADMINISTRATIVE_STATE IF_OPER_STATUS NET_IF_ACCESS_TYPE NET_IF_ADMIN_STATUS NET_IF_CONNECTION_TYPE NET_IF_DIRECTION_TYPE NET_IF_MEDIA_CONNECT_STATE NET_IF_MEDIA_DUPLEX_STATE NET_IF_OPER_STATUS NET_IF_RCV_ADDRESS_TYPE TUNNEL_TYPE GetAdaptersAddressesFlags IFTYPE IP_DAD_STATE IP_PREFIX_ORIGIN IP_SUFFIX_ORIGIN NDIS_MEDIUM NDIS_PHYSICAL_MEDIUM NET_ADDRESS_FORMAT NET_STRING NetBiosNodeType SCOPE_LEVEL TCP_TABLE_CLASS TCPIP_OWNER_MODULE_INFO_CLASS UDP_TABLE_CLASS IP_ADAPTER_CAST_FLAGS IP_ADAPTER_FLAGS MIB_IPADDRTYPE MIB_IPFORWARD_PROTO MIB_IPFORWARD_TYPE MIB_IPNET_TYPE MIB_IPSTATS_FORWARDING MIB_TCP_STATE InterfaceAndOperStatusFlags MIB_IF_ENTRY_LEVEL MIB_IF_TABLE_LEVEL MIB_IPNET_ROW2_FLAGS MIB_NOTIFICATION_TYPE NL_DAD_STATE NL_LINK_LOCAL_ADDRESS_BEHAVIOR NL_NEIGHBOR_STATE NL_NETWORK_CONNECTIVITY_COST_HINT NL_NETWORK_CONNECTIVITY_LEVEL_HINT NL_PREFIX_ORIGIN NL_ROUTE_ORIGIN NL_ROUTER_DISCOVERY_BEHAVIOR NL_SUFFIX_ORIGIN TCP_BOOLEAN_OPTIONAL TCP_ESTATS_TYPE TCP_SOFT_ERROR TCP_CONNECTION_OFFLOAD_STATE TCP_RTO_ALGORITHM SupportedFlags                                                                                                               | IO_STATUS_BLOCK IF_COUNTED_STRING IF_PHYSICAL_ADDRESS NDIS_INTERFACE_INFORMATION NET_IF_ALIAS NET_IF_RCV_ADDRESS NET_LUID NET_PHYSICAL_LOCATION MIB_IFROW IP_ADAPTER_INDEX_MAP IP_OPTION_INFORMATION HIFTIMESTAMPCHANGE INTERFACE_HARDWARE_TIMESTAMP_CAPABILITIES INTERFACE_SOFTWARE_TIMESTAMP_CAPABILITIES INTERFACE_TIMESTAMP_CAPABILITIES NET_ADDRESS_INFO TCPIP_OWNER_MODULE_BASIC_INFO TCPIP_OWNER_MODULE_BASIC_INFO_UNMGD FIXED_INFO IP_ADAPTER_ADDRESSES IP_ADAPTER_ANYCAST_ADDRESS IP_ADAPTER_DNS_SERVER_ADDRESS IP_ADAPTER_DNS_SUFFIX IP_ADAPTER_GATEWAY_ADDRESS IP_ADAPTER_INFO IP_ADAPTER_MULTICAST_ADDRESS IP_ADAPTER_PREFIX IP_ADAPTER_UNICAST_ADDRESS IP_ADAPTER_WINS_SERVER_ADDRESS IP_ADDR_STRING IP_ADDRESS_STRING IP_INTERFACE_NAME_INFO IP_PER_ADAPTER_INFO MIB_ICMP MIB_ICMP_EX MIB_IPADDRROW MIB_IPFORWARDROW MIB_IPNETROW MIB_IPSTATS MIBICMPINFO MIBICMPSTATS MIBICMPSTATS_EX IP_ADDRESS_PREFIX MIB_ANYCASTIPADDRESS_ROW MIB_IF_ROW2 MIB_IFSTACK_ROW MIB_INVERTEDIFSTACK_ROW MIB_IP_NETWORK_CONNECTION_BANDWIDTH_ESTIMATES MIB_IPFORWARD_ROW2 MIB_IPINTERFACE_ROW MIB_IPNET_ROW2 MIB_IPNET_ROW2_Unmanaged MIB_IPPATH_ROW MIB_MULTICASTIPADDRESS_ROW MIB_UNICASTIPADDRESS_ROW NL_BANDWIDTH_INFORMATION NL_INTERFACE_OFFLOAD_ROD NL_NETWORK_CONNECTIVITY_HINT TCP_ESTATS_BANDWIDTH_ROD_v0 TCP_ESTATS_BANDWIDTH_RW_v0 TCP_ESTATS_DATA_ROD_v0 TCP_ESTATS_DATA_RW_v0 TCP_ESTATS_FINE_RTT_ROD_v0 TCP_ESTATS_FINE_RTT_RW_v0 TCP_ESTATS_OBS_REC_ROD_v0 TCP_ESTATS_OBS_REC_RW_v0 TCP_ESTATS_PATH_ROD_v0 TCP_ESTATS_PATH_RW_v0 TCP_ESTATS_REC_ROD_v0 TCP_ESTATS_REC_RW_v0 TCP_ESTATS_SEND_BUFF_ROD_v0 TCP_ESTATS_SEND_BUFF_RW_v0 TCP_ESTATS_SND_CONG_ROD_v0 TCP_ESTATS_SND_CONG_ROS_v0 TCP_ESTATS_SND_CONG_RW_v0 TCP_ESTATS_SYN_OPTS_ROS_v0 MIB_TCP6ROW MIB_TCP6ROW_OWNER_MODULE MIB_TCP6ROW_OWNER_PID MIB_TCP6ROW2 MIB_TCPROW MIB_TCPROW_OWNER_MODULE MIB_TCPROW_OWNER_PID MIB_TCPROW2 MIB_TCPSTATS MIB_TCPSTATS2 MIB_UDP6ROW MIB_UDP6ROW_OWNER_MODULE MIB_UDP6ROW_OWNER_PID MIB_UDPROW MIB_UDPROW_OWNER_MODULE MIB_UDPROW_OWNER_PID MIB_UDPSTATS MIB_UDPSTATS2 NAMEDADDRESS <PhysicalAddress>e__FixedBuffer                                                                   