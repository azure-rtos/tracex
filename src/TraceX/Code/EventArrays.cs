﻿using System.Windows.Media;
using System.Collections.Generic;
using System.Globalization;
using AzureRTOS.Tml;

namespace AzureRTOS.TraceManagement.Code
{
    public static class EventArrays
    {
        public static uint[] TmlTxEvents =
        {
            TmlDefines.TML_TRACE_THREAD_RESUME,
            TmlDefines.TML_TRACE_THREAD_SUSPEND,
            TmlDefines.TML_TRACE_ISR_ENTER,
            TmlDefines.TML_TRACE_ISR_EXIT,
            TmlDefines.TML_TRACE_TIME_SLICE,
            TmlDefines.TML_TRACE_RUNNING,
            TmlDefines.TML_TRACE_BLOCK_ALLOCATE,
            TmlDefines.TML_TRACE_BLOCK_POOL_CREATE,
            TmlDefines.TML_TRACE_BLOCK_POOL_DELETE,
            TmlDefines.TML_TRACE_BLOCK_POOL_INFO_GET,
            TmlDefines.TML_TRACE_BLOCK_POOL_PERFORMANCE_INFO_GET,
            TmlDefines.TML_TRACE_BLOCK_POOL_PERFORMANCE_SYSTEM_INFO_GET,
            TmlDefines.TML_TRACE_BLOCK_POOL_PRIORITIZE,
            TmlDefines.TML_TRACE_BLOCK_RELEASE,
            TmlDefines.TML_TRACE_BYTE_ALLOCATE,
            TmlDefines.TML_TRACE_BYTE_POOL_CREATE,
            TmlDefines.TML_TRACE_BYTE_POOL_DELETE,
            TmlDefines.TML_TRACE_BYTE_POOL_INFO_GET,
            TmlDefines.TML_TRACE_BYTE_POOL_PERFORMANCE_INFO_GET,
            TmlDefines.TML_TRACE_BYTE_POOL_PERFORMANCE_SYSTEM_INFO_GET,
            TmlDefines.TML_TRACE_BYTE_POOL_PRIORITIZE,
            TmlDefines.TML_TRACE_BYTE_RELEASE,
            TmlDefines.TML_TRACE_EVENT_FLAGS_CREATE,
            TmlDefines.TML_TRACE_EVENT_FLAGS_DELETE,
            TmlDefines.TML_TRACE_EVENT_FLAGS_GET,
            TmlDefines.TML_TRACE_EVENT_FLAGS_INFO_GET,
            TmlDefines.TML_TRACE_EVENT_FLAGS_PERFORMANCE_INFO_GET,
            TmlDefines.TML_TRACE_EVENT_FLAGS_PERFORMANCE_SYSTEM_INFO_GET,
            TmlDefines.TML_TRACE_EVENT_FLAGS_SET,
            TmlDefines.TML_TRACE_EVENT_FLAGS_SET_NOTIFY,
            TmlDefines.TML_TRACE_INTERRUPT_CONTROL,
            TmlDefines.TML_TRACE_MUTEX_CREATE,
            TmlDefines.TML_TRACE_MUTEX_DELETE,
            TmlDefines.TML_TRACE_MUTEX_GET,
            TmlDefines.TML_TRACE_MUTEX_INFO_GET,
            TmlDefines.TML_TRACE_MUTEX_PERFORMANCE_INFO_GET,
            TmlDefines.TML_TRACE_MUTEX_PERFORMANCE_SYSTEM_INFO_GET,
            TmlDefines.TML_TRACE_MUTEX_PRIORITIZE,
            TmlDefines.TML_TRACE_MUTEX_PUT,
            TmlDefines.TML_TRACE_QUEUE_CREATE,
            TmlDefines.TML_TRACE_QUEUE_DELETE,
            TmlDefines.TML_TRACE_QUEUE_FLUSH,
            TmlDefines.TML_TRACE_QUEUE_FRONT_SEND,
            TmlDefines.TML_TRACE_QUEUE_INFO_GET,
            TmlDefines.TML_TRACE_QUEUE_PERFORMANCE_INFO_GET,
            TmlDefines.TML_TRACE_QUEUE_PERFORMANCE_SYSTEM_INFO_GET,
            TmlDefines.TML_TRACE_QUEUE_PRIORITIZE,
            TmlDefines.TML_TRACE_QUEUE_RECEIVE,
            TmlDefines.TML_TRACE_QUEUE_SEND,
            TmlDefines.TML_TRACE_QUEUE_SEND_NOTIFY,
            TmlDefines.TML_TRACE_SEMAPHORE_CEILING_PUT,
            TmlDefines.TML_TRACE_SEMAPHORE_CREATE,
            TmlDefines.TML_TRACE_SEMAPHORE_DELETE,
            TmlDefines.TML_TRACE_SEMAPHORE_GET,
            TmlDefines.TML_TRACE_SEMAPHORE_INFO_GET,
            TmlDefines.TML_TRACE_SEMAPHORE_PERFORMANCE_INFO_GET,
            TmlDefines.TML_TRACE_SEMAPHORE_PERFORMANCE_SYSTEM_INFO_GET,
            TmlDefines.TML_TRACE_SEMAPHORE_PRIORITIZE,
            TmlDefines.TML_TRACE_SEMAPHORE_PUT,
            TmlDefines.TML_TRACE_SEMAPHORE_PUT_NOTIFY,
            TmlDefines.TML_TRACE_THREAD_CREATE,
            TmlDefines.TML_TRACE_THREAD_DELETE,
            TmlDefines.TML_TRACE_THREAD_ENTRY_EXIT_NOTIFY,
            TmlDefines.TML_TRACE_THREAD_IDENTIFY,
            TmlDefines.TML_TRACE_THREAD_INFO_GET,
            TmlDefines.TML_TRACE_THREAD_PERFORMANCE_INFO_GET,
            TmlDefines.TML_TRACE_THREAD_PERFORMANCE_SYSTEM_INFO_GET,
            TmlDefines.TML_TRACE_THREAD_PREEMPTION_CHANGE,
            TmlDefines.TML_TRACE_THREAD_PRIORITY_CHANGE,
            TmlDefines.TML_TRACE_THREAD_RELINQUISH,
            TmlDefines.TML_TRACE_THREAD_RESET,
            TmlDefines.TML_TRACE_THREAD_RESUME_API,
            TmlDefines.TML_TRACE_THREAD_SLEEP,
            TmlDefines.TML_TRACE_THREAD_STACK_ERROR_NOTIFY,
            TmlDefines.TML_TRACE_THREAD_SUSPEND_API,
            TmlDefines.TML_TRACE_THREAD_TERMINATE,
            TmlDefines.TML_TRACE_THREAD_TIME_SLICE_CHANGE,
            TmlDefines.TML_TRACE_THREAD_WAIT_ABORT,
            TmlDefines.TML_TRACE_TIME_GET,
            TmlDefines.TML_TRACE_TIME_SET,
            TmlDefines.TML_TRACE_TIMER_ACTIVATE,
            TmlDefines.TML_TRACE_TIMER_CHANGE,
            TmlDefines.TML_TRACE_TIMER_CREATE,
            TmlDefines.TML_TRACE_TIMER_DEACTIVATE,
            TmlDefines.TML_TRACE_TIMER_DELETE,
            TmlDefines.TML_TRACE_TIMER_INFO_GET,
            TmlDefines.TML_TRACE_TIMER_PERFORMANCE_INFO_GET,
            TmlDefines.TML_TRACE_TIMER_PERFORMANCE_SYSTEM_INFO_GET,
            TmlDefines.TML_TRACE_USER_EVENT_START
        };

        public static uint[] TmlFxEvents =
        {
            TmlDefines.TML_FX_TRACE_INTERNAL_LOG_SECTOR_CACHE_MISS,
            TmlDefines.TML_FX_TRACE_INTERNAL_DIR_CACHE_MISS,
            TmlDefines.TML_FX_TRACE_INTERNAL_MEDIA_FLUSH,
            TmlDefines.TML_FX_TRACE_INTERNAL_DIR_ENTRY_READ,
            TmlDefines.TML_FX_TRACE_INTERNAL_DIR_ENTRY_WRITE,
            TmlDefines.TML_FX_TRACE_INTERNAL_IO_DRIVER_READ,
            TmlDefines.TML_FX_TRACE_INTERNAL_IO_DRIVER_WRITE,
            TmlDefines.TML_FX_TRACE_INTERNAL_IO_DRIVER_FLUSH,
            TmlDefines.TML_FX_TRACE_INTERNAL_IO_DRIVER_ABORT,
            TmlDefines.TML_FX_TRACE_INTERNAL_IO_DRIVER_INIT,
            TmlDefines.TML_FX_TRACE_INTERNAL_IO_DRIVER_BOOT_READ,
            TmlDefines.TML_FX_TRACE_INTERNAL_IO_DRIVER_RELEASE_SECTORS,
            TmlDefines.TML_FX_TRACE_INTERNAL_IO_DRIVER_BOOT_WRITE,
            TmlDefines.TML_FX_TRACE_INTERNAL_IO_DRIVER_UNINIT,
            TmlDefines.TML_FX_TRACE_DIRECTORY_ATTRIBUTES_READ,
            TmlDefines.TML_FX_TRACE_DIRECTORY_ATTRIBUTES_SET,
            TmlDefines.TML_FX_TRACE_DIRECTORY_CREATE,
            TmlDefines.TML_FX_TRACE_DIRECTORY_DEFAULT_GET,
            TmlDefines.TML_FX_TRACE_DIRECTORY_DEFAULT_SET,
            TmlDefines.TML_FX_TRACE_DIRECTORY_DELETE,
            TmlDefines.TML_FX_TRACE_DIRECTORY_FIRST_ENTRY_FIND,
            TmlDefines.TML_FX_TRACE_DIRECTORY_FIRST_FULL_ENTRY_FIND,
            TmlDefines.TML_FX_TRACE_DIRECTORY_INFORMATION_GET,
            TmlDefines.TML_FX_TRACE_DIRECTORY_LOCAL_PATH_CLEAR,
            TmlDefines.TML_FX_TRACE_DIRECTORY_LOCAL_PATH_GET,
            TmlDefines.TML_FX_TRACE_DIRECTORY_LOCAL_PATH_RESTORE,
            TmlDefines.TML_FX_TRACE_DIRECTORY_LOCAL_PATH_SET,
            TmlDefines.TML_FX_TRACE_DIRECTORY_LONG_NAME_GET,
            TmlDefines.TML_FX_TRACE_DIRECTORY_NAME_TEST,
            TmlDefines.TML_FX_TRACE_DIRECTORY_NEXT_ENTRY_FIND,
            TmlDefines.TML_FX_TRACE_DIRECTORY_NEXT_FULL_ENTRY_FIND,
            TmlDefines.TML_FX_TRACE_DIRECTORY_RENAME,
            TmlDefines.TML_FX_TRACE_DIRECTORY_SHORT_NAME_GET,
            TmlDefines.TML_FX_TRACE_FILE_ALLOCATE,
            TmlDefines.TML_FX_TRACE_FILE_ATTRIBUTES_READ,
            TmlDefines.TML_FX_TRACE_FILE_ATTRIBUTES_SET,
            TmlDefines.TML_FX_TRACE_FILE_BEST_EFFORT_ALLOCATE,
            TmlDefines.TML_FX_TRACE_FILE_CLOSE,
            TmlDefines.TML_FX_TRACE_FILE_CREATE,
            TmlDefines.TML_FX_TRACE_FILE_DATE_TIME_SET,
            TmlDefines.TML_FX_TRACE_FILE_DELETE,
            TmlDefines.TML_FX_TRACE_FILE_OPEN,
            TmlDefines.TML_FX_TRACE_FILE_READ,
            TmlDefines.TML_FX_TRACE_FILE_RELATIVE_SEEK,
            TmlDefines.TML_FX_TRACE_FILE_RENAME,
            TmlDefines.TML_FX_TRACE_FILE_SEEK,
            TmlDefines.TML_FX_TRACE_FILE_TRUNCATE,
            TmlDefines.TML_FX_TRACE_FILE_TRUNCATE_RELEASE,
            TmlDefines.TML_FX_TRACE_FILE_WRITE,
            TmlDefines.TML_FX_TRACE_MEDIA_ABORT,
            TmlDefines.TML_FX_TRACE_MEDIA_CACHE_INVALIDATE,
            TmlDefines.TML_FX_TRACE_MEDIA_CHECK,
            TmlDefines.TML_FX_TRACE_MEDIA_CLOSE,
            TmlDefines.TML_FX_TRACE_MEDIA_FLUSH,
            TmlDefines.TML_FX_TRACE_MEDIA_FORMAT,
            TmlDefines.TML_FX_TRACE_MEDIA_OPEN,
            TmlDefines.TML_FX_TRACE_MEDIA_READ,
            TmlDefines.TML_FX_TRACE_MEDIA_SPACE_AVAILABLE,
            TmlDefines.TML_FX_TRACE_MEDIA_VOLUME_GET,
            TmlDefines.TML_FX_TRACE_MEDIA_VOLUME_SET,
            TmlDefines.TML_FX_TRACE_MEDIA_WRITE,
            TmlDefines.TML_FX_TRACE_SYSTEM_DATE_GET,
            TmlDefines.TML_FX_TRACE_SYSTEM_DATE_SET,
            TmlDefines.TML_FX_TRACE_SYSTEM_INITIALIZE,
            TmlDefines.TML_FX_TRACE_SYSTEM_TIME_GET,
            TmlDefines.TML_FX_TRACE_SYSTEM_TIME_SET,
            TmlDefines.TML_FX_TRACE_UNICODE_DIRECTORY_CREATE,
            TmlDefines.TML_FX_TRACE_UNICODE_DIRECTORY_RENAME,
            TmlDefines.TML_FX_TRACE_UNICODE_FILE_CREATE,
            TmlDefines.TML_FX_TRACE_UNICODE_FILE_RENAME,
            TmlDefines.TML_FX_TRACE_UNICODE_LENGTH_GET,
            TmlDefines.TML_FX_TRACE_UNICODE_NAME_GET,
            TmlDefines.TML_FX_TRACE_UNICODE_SHORT_NAME_GET,
            TmlDefines.TML_TRACE_USER_EVENT_START
        };

        public static uint[] TmlNxEvents =
        {
            TmlDefines.TML_NX_TRACE_INTERNAL_ARP_REQUEST_RECEIVE,
            TmlDefines.TML_NX_TRACE_INTERNAL_ARP_REQUEST_SEND,
            TmlDefines.TML_NX_TRACE_INTERNAL_ARP_RESPONSE_RECEIVE,
            TmlDefines.TML_NX_TRACE_INTERNAL_ARP_RESPONSE_SEND,
            TmlDefines.TML_NX_TRACE_INTERNAL_ICMP_RECEIVE,
            TmlDefines.TML_NX_TRACE_INTERNAL_ICMP_SEND,
            TmlDefines.TML_NX_TRACE_INTERNAL_IGMP_RECEIVE,
            TmlDefines.TML_NX_TRACE_INTERNAL_IP_RECEIVE,
            TmlDefines.TML_NX_TRACE_INTERNAL_IP_SEND,
            TmlDefines.TML_NX_TRACE_INTERNAL_TCP_DATA_RECEIVE,
            TmlDefines.TML_NX_TRACE_INTERNAL_TCP_DATA_SEND,
            TmlDefines.TML_NX_TRACE_INTERNAL_TCP_FIN_RECEIVE,
            TmlDefines.TML_NX_TRACE_INTERNAL_TCP_FIN_SEND,
            TmlDefines.TML_NX_TRACE_INTERNAL_TCP_RESET_RECEIVE,
            TmlDefines.TML_NX_TRACE_INTERNAL_TCP_RESET_SEND,
            TmlDefines.TML_NX_TRACE_INTERNAL_TCP_SYN_RECEIVE,
            TmlDefines.TML_NX_TRACE_INTERNAL_TCP_SYN_SEND,
            TmlDefines.TML_NX_TRACE_INTERNAL_UDP_RECEIVE,
            TmlDefines.TML_NX_TRACE_INTERNAL_UDP_SEND,
            TmlDefines.TML_NX_TRACE_INTERNAL_RARP_RECEIVE,
            TmlDefines.TML_NX_TRACE_INTERNAL_RARP_SEND,
            TmlDefines.TML_NX_TRACE_INTERNAL_TCP_RETRY,
            TmlDefines.TML_NX_TRACE_INTERNAL_TCP_STATE_CHANGE,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_PACKET_SEND,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_INITIALIZE,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_LINK_ENABLE,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_LINK_DISABLE,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_PACKET_BROADCAST,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_ARP_SEND,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_ARP_RESPONSE_SEND,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_RARP_SEND,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_MULTICAST_JOIN,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_MULTICAST_LEAVE,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_GET_STATUS,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_GET_SPEED,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_GET_DUPLEX_TYPE,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_GET_ERROR_COUNT,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_GET_RX_COUNT,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_GET_TX_COUNT,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_GET_ALLOC_ERRORS,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_UNINITIALIZE,
            TmlDefines.TML_NX_TRACE_INTERNAL_IO_DRIVER_DEFERRED_PROCESSING,
            TmlDefines.TML_NX_TRACE_ARP_DYNAMIC_ENTRIES_INVALIDATE,
            TmlDefines.TML_NX_TRACE_ARP_DYNAMIC_ENTRY_SET,
            TmlDefines.TML_NX_TRACE_ARP_ENABLE,
            TmlDefines.TML_NX_TRACE_ARP_GRATUITOUS_SEND,
            TmlDefines.TML_NX_TRACE_ARP_HARDWARE_ADDRESS_FIND,
            TmlDefines.TML_NX_TRACE_ARP_INFO_GET,
            TmlDefines.TML_NX_TRACE_ARP_IP_ADDRESS_FIND,
            TmlDefines.TML_NX_TRACE_ARP_STATIC_ENTRIES_DELETE,
            TmlDefines.TML_NX_TRACE_ARP_STATIC_ENTRY_CREATE,
            TmlDefines.TML_NX_TRACE_ARP_STATIC_ENTRY_DELETE,
            TmlDefines.TML_NXD_TRACE_ND_CACHE_DELETE,
            TmlDefines.TML_NXD_TRACE_ND_CACHE_ENTRY_SET,
            TmlDefines.TML_NXD_TRACE_ND_CACHE_INVALIDATE,
            TmlDefines.TML_NXD_TRACE_ND_CACHE_IP_ADDRESS_FIND,
            TmlDefines.TML_NXD_TRACE_ICMP_ENABLE,
            TmlDefines.TML_NX_TRACE_ICMP_PING6,
            TmlDefines.TML_NXD_TRACE_IP_MAX_PAYLOAD_SIZE_FIND,
            TmlDefines.TML_NXD_TRACE_IP_RAW_PACKET_SEND,
            TmlDefines.TML_NXD_TRACE_IPV6_DEFAULT_ROUTER_ADD,
            TmlDefines.TML_NXD_TRACE_IPV6_DEFAULT_ROUTER_DELETE,
            TmlDefines.TML_NXD_TRACE_IPV6_ENABLE,
            TmlDefines.TML_NXD_TRACE_IPV6_GLOBAL_ADDRESS_GET,
            TmlDefines.TML_NXD_TRACE_IPV6_GLOBAL_ADDRESS_SET,
            TmlDefines.TML_NXD_TRACE_IPV6_INITIATE_DAD_PROCESS,
            TmlDefines.TML_NXD_TRACE_IPV6_INTERFACE_ADDRESS_GET,
            TmlDefines.TML_NXD_TRACE_IPV6_INTERFACE_ADDRESS_SET,
            TmlDefines.TML_NXD_TRACE_IPV6_LINKLOCAL_ADDRESS_GET,
            TmlDefines.TML_NXD_TRACE_IPV6_LINKLOCAL_ADDRESS_SET,
            TmlDefines.TML_NXD_TRACE_IPV6_RAW_PACKET_SEND,
            TmlDefines.TML_NXD_TRACE_TCP_SOCKET_PEER_INFO_GET,
            TmlDefines.TML_NXD_TRACE_TCP_SOCKET_SET_INTERFACE,
            TmlDefines.TML_NXD_TRACE_UDP_SOCKET_SEND,
            TmlDefines.TML_NXD_TRACE_UDP_SOCKET_SET_INTERFACE,
            TmlDefines.TML_NXD_TRACE_UDP_SOURCE_EXTRACT,
            TmlDefines.TML_NX_TRACE_ICMP_ENABLE,
            TmlDefines.TML_NX_TRACE_ICMP_INFO_GET,
            TmlDefines.TML_NX_TRACE_ICMP_PING,
            TmlDefines.TML_NX_TRACE_IGMP_ENABLE,
            TmlDefines.TML_NX_TRACE_IGMP_INFO_GET,
            TmlDefines.TML_NX_TRACE_IGMP_LOOPBACK_DISABLE,
            TmlDefines.TML_NX_TRACE_IGMP_LOOPBACK_ENABLE,
            TmlDefines.TML_NX_TRACE_IGMP_MULTICAST_JOIN,
            TmlDefines.TML_NX_TRACE_IGMP_MULTICAST_LEAVE,
            TmlDefines.TML_NX_TRACE_IP_ADDRESS_CHANGE_NOTIFY,
            TmlDefines.TML_NX_TRACE_IP_ADDRESS_GET,
            TmlDefines.TML_NX_TRACE_IP_ADDRESS_SET,
            TmlDefines.TML_NX_TRACE_IP_CREATE,
            TmlDefines.TML_NX_TRACE_IP_DELETE,
            TmlDefines.TML_NX_TRACE_IP_DRIVER_DIRECT_COMMAND,
            TmlDefines.TML_NX_TRACE_IP_FORWARDING_DISABLE,
            TmlDefines.TML_NX_TRACE_IP_FORWARDING_ENABLE,
            TmlDefines.TML_NX_TRACE_IP_FRAGMENT_DISABLE,
            TmlDefines.TML_NX_TRACE_IP_FRAGMENT_ENABLE,
            TmlDefines.TML_NX_TRACE_IP_GATEWAY_ADDRESS_SET,
            TmlDefines.TML_NX_TRACE_IP_INFO_GET,
            TmlDefines.TML_NX_TRACE_IP_INTERFACE_ATTACH,
            TmlDefines.TML_NX_TRACE_IP_INTERFACE_INFO_GET,
            TmlDefines.TML_NX_TRACE_IP_RAW_PACKET_DISABLE,
            TmlDefines.TML_NX_TRACE_IP_RAW_PACKET_ENABLE,
            TmlDefines.TML_NX_TRACE_IP_RAW_PACKET_RECEIVE,
            TmlDefines.TML_NX_TRACE_IP_RAW_PACKET_SEND,
            TmlDefines.TML_NX_TRACE_IP_STATIC_ROUTE_ADD,
            TmlDefines.TML_NX_TRACE_IP_STATIC_ROUTE_DELETE,
            TmlDefines.TML_NX_TRACE_IP_STATUS_CHECK,
            TmlDefines.TML_NX_TRACE_IPSEC_ENABLE,
            TmlDefines.TML_NX_TRACE_PACKET_ALLOCATE,
            TmlDefines.TML_NX_TRACE_PACKET_COPY,
            TmlDefines.TML_NX_TRACE_PACKET_DATA_APPEND,
            TmlDefines.TML_NX_TRACE_PACKET_DATA_EXTRACT_OFFSET,
            TmlDefines.TML_NX_TRACE_PACKET_DATA_RETRIEVE,
            TmlDefines.TML_NX_TRACE_PACKET_LENGTH_GET,
            TmlDefines.TML_NX_TRACE_PACKET_POOL_CREATE,
            TmlDefines.TML_NX_TRACE_PACKET_POOL_DELETE,
            TmlDefines.TML_NX_TRACE_PACKET_POOL_INFO_GET,
            TmlDefines.TML_NX_TRACE_PACKET_RELEASE,
            TmlDefines.TML_NX_TRACE_PACKET_TRANSMIT_RELEASE,
            TmlDefines.TML_NX_TRACE_RARP_DISABLE,
            TmlDefines.TML_NX_TRACE_RARP_ENABLE,
            TmlDefines.TML_NX_TRACE_RARP_INFO_GET,
            TmlDefines.TML_NX_TRACE_SYSTEM_INITIALIZE,
            TmlDefines.TML_NX_TRACE_TCP_CLIENT_SOCKET_BIND,
            TmlDefines.TML_NX_TRACE_TCP_CLIENT_SOCKET_CONNECT,
            TmlDefines.TML_NX_TRACE_TCP_CLIENT_SOCKET_PORT_GET,
            TmlDefines.TML_NX_TRACE_TCP_CLIENT_SOCKET_UNBIND,
            TmlDefines.TML_NX_TRACE_TCP_ENABLE,
            TmlDefines.TML_NX_TRACE_TCP_FREE_PORT_FIND,
            TmlDefines.TML_NX_TRACE_TCP_INFO_GET,
            TmlDefines.TML_NX_TRACE_TCP_SERVER_SOCKET_ACCEPT,
            TmlDefines.TML_NX_TRACE_TCP_SERVER_SOCKET_LISTEN,
            TmlDefines.TML_NX_TRACE_TCP_SERVER_SOCKET_RELISTEN,
            TmlDefines.TML_NX_TRACE_TCP_SERVER_SOCKET_UNACCEPT,
            TmlDefines.TML_NX_TRACE_TCP_SERVER_SOCKET_UNLISTEN,
            TmlDefines.TML_NX_TRACE_TCP_SOCKET_BYTES_AVAILABLE,
            TmlDefines.TML_NX_TRACE_TCP_SOCKET_CREATE,
            TmlDefines.TML_NX_TRACE_TCP_SOCKET_DELETE,
            TmlDefines.TML_NX_TRACE_TCP_SOCKET_DISCONNECT,
            TmlDefines.TML_NX_TRACE_TCP_SOCKET_INFO_GET,
            TmlDefines.TML_NX_TRACE_TCP_SOCKET_MSS_GET,
            TmlDefines.TML_NX_TRACE_TCP_SOCKET_MSS_PEER_GET,
            TmlDefines.TML_NX_TRACE_TCP_SOCKET_MSS_SET,
            TmlDefines.TML_NX_TRACE_TCP_SOCKET_PEER_INFO_GET,
            TmlDefines.TML_NX_TRACE_TCP_SOCKET_RECEIVE,
            TmlDefines.TML_NX_TRACE_TCP_SOCKET_RECEIVE_NOTIFY,
            TmlDefines.TML_NX_TRACE_TCP_SOCKET_SEND,
            TmlDefines.TML_NX_TRACE_TCP_SOCKET_STATE_WAIT,
            TmlDefines.TML_NX_TRACE_TCP_SOCKET_TRANSMIT_CONFIGURE,
            TmlDefines.TML_NX_TRACE_TCP_SOCKET_WINDOW_UPDATE_NOTIFY_SET,
            TmlDefines.TML_NX_TRACE_UDP_ENABLE,
            TmlDefines.TML_NX_TRACE_UDP_FREE_PORT_FIND,
            TmlDefines.TML_NX_TRACE_UDP_INFO_GET,
            TmlDefines.TML_NX_TRACE_UDP_SOCKET_BIND,
            TmlDefines.TML_NX_TRACE_UDP_SOCKET_BYTES_AVAILABLE,
            TmlDefines.TML_NX_TRACE_UDP_SOCKET_CHECKSUM_DISABLE,
            TmlDefines.TML_NX_TRACE_UDP_SOCKET_CHECKSUM_ENABLE,
            TmlDefines.TML_NX_TRACE_UDP_SOCKET_CREATE,
            TmlDefines.TML_NX_TRACE_UDP_SOCKET_DELETE,
            TmlDefines.TML_NX_TRACE_UDP_SOCKET_INFO_GET,
            TmlDefines.TML_NX_TRACE_UDP_SOCKET_INTERFACE_SET,
            TmlDefines.TML_NX_TRACE_UDP_SOCKET_PORT_GET,
            TmlDefines.TML_NX_TRACE_UDP_SOCKET_RECEIVE,
            TmlDefines.TML_NX_TRACE_UDP_SOCKET_RECEIVE_NOTIFY,
            TmlDefines.TML_NX_TRACE_UDP_SOCKET_SEND,
            TmlDefines.TML_NX_TRACE_UDP_SOCKET_UNBIND,
            TmlDefines.TML_NX_TRACE_UDP_SOURCE_EXTRACT,
            TmlDefines.TML_TRACE_USER_EVENT_START
        };

        public static uint[] TmlUxEvents =
        {
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_CDC_ACTIVATE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_CDC_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_CDC_READ,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_CDC_WRITE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_DPUMP_ACTIVATE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_DPUMP_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_DPUMP_READ,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_DPUMP_WRITE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_HID_ACTIVATE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_HID_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_HID_DESCRIPTOR_SEND,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_HID_EVENT_GET,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_HID_EVENT_SET,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_HID_REPORT_GET,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_HID_REPORT_SET,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_PIMA_ACTIVATE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_PIMA_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_PIMA_DEVICE_INFO_SEND,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_PIMA_EVENT_GET,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_PIMA_EVENT_SET,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_PIMA_OBJECT_ADD,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_PIMA_OBJECT_DATA_GET,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_PIMA_OBJECT_DATA_SEND,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_PIMA_OBJECT_DELETE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_PIMA_OBJECT_HANDLES_SEND,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_PIMA_OBJECT_INFO_GET,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_PIMA_OBJECT_INFO_SEND,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_PIMA_OBJECTS_NUMBER_SEND,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_PIMA_PARTIAL_OBJECT_DATA_GET,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_PIMA_RESPONSE_SEND,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_PIMA_STORAGE_ID_SEND,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_PIMA_STORAGE_INFO_SEND,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_RNDIS_ACTIVATE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_RNDIS_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_RNDIS_MSG_KEEP_ALIVE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_RNDIS_MSG_QUERY,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_RNDIS_MSG_RESET,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_RNDIS_MSG_SET,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_RNDIS_PACKET_RECEIVE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_RNDIS_PACKET_TRANSMIT,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_STORAGE_ACTIVATE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_STORAGE_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_STORAGE_FORMAT,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_STORAGE_INQUIRY,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_STORAGE_MODE_SELECT,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_STORAGE_MODE_SENSE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_STORAGE_PREVENT_ALLOW_MEDIA_REMOVAL,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_STORAGE_READ,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_STORAGE_READ_CAPACITY,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_STORAGE_READ_FORMAT_CAPACITY,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_STORAGE_READ_TOC,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_STORAGE_REQUEST_SENSE,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_STORAGE_START_STOP,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_STORAGE_TEST_READY,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_STORAGE_VERIFY,
            TmlDefines.TML_UX_TRACE_DEVICE_CLASS_STORAGE_WRITE,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_ALTERNATE_SETTING_GET,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_ALTERNATE_SETTING_SET,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_CLASS_REGISTER,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_CLEAR_FEATURE,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_CONFIGURATION_GET,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_CONFIGURATION_SET,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_CONNECT,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_DESCRIPTOR_SEND,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_DISCONNECT,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_ENDPOINT_STALL,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_GET_STATUS,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_HOST_WAKEUP,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_INITIALIZE,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_INTERFACE_DELETE,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_INTERFACE_GET,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_INTERFACE_SET,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_SET_FEATURE,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_TRANSFER_ABORT,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_TRANSFER_ALL_REQUEST_ABORT,
            TmlDefines.TML_UX_TRACE_DEVICE_STACK_TRANSFER_REQUEST,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_ASIX_ACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_ASIX_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_ASIX_INTERRUPT_NOTIFICATION,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_ASIX_READ,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_ASIX_WRITE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_AUDIO_ACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_AUDIO_CONTROL_VALUE_GET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_AUDIO_CONTROL_VALUE_SET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_AUDIO_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_AUDIO_READ,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_AUDIO_STREAMING_SAMPLING_GET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_AUDIO_STREAMING_SAMPLING_SET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_AUDIO_WRITE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_CDC_ACM_ACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_CDC_ACM_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_CDC_ACM_IOCTL_ABORT_IN_PIPE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_CDC_ACM_IOCTL_ABORT_OUT_PIPE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_CDC_ACM_IOCTL_GET_DEVICE_STATUS,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_CDC_ACM_IOCTL_GET_LINE_CODING,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_CDC_ACM_IOCTL_NOTIFICATION_CALLBACK,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_CDC_ACM_IOCTL_SEND_BREAK,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_CDC_ACM_IOCTL_SET_LINE_CODING,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_CDC_ACM_IOCTL_SET_LINE_STATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_CDC_ACM_READ,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_CDC_ACM_RECEPTION_START,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_CDC_ACM_RECEPTION_STOP,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_CDC_ACM_WRITE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_DPUMP_ACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_DPUMP_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_DPUMP_READ,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_DPUMP_WRITE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HID_ACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HID_CLIENT_REGISTER,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HID_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HID_IDLE_GET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HID_IDLE_SET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HID_KEYBOARD_ACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HID_KEYBOARD_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HID_MOUSE_ACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HID_MOUSE_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HID_REMOTE_CONTROL_ACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HID_REMOTE_CONTROL_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HID_REPORT_GET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HID_REPORT_SET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HUB_ACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HUB_CHANGE_DETECT,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HUB_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HUB_PORT_CHANGE_CONNECTION_PROCESS,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HUB_PORT_CHANGE_ENABLE_PROCESS,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HUB_PORT_CHANGE_OVER_CURRENT_PROCESS,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HUB_PORT_CHANGE_RESET_PROCESS,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_HUB_PORT_CHANGE_SUSPEND_PROCESS,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_ACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_DEVICE_INFO_GET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_DEVICE_RESET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_NOTIFICATION,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_NUM_OBJECTS_GET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_OBJECT_CLOSE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_OBJECT_COPY,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_OBJECT_DELETE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_OBJECT_GET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_OBJECT_INFO_GET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_OBJECT_INFO_SEND,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_OBJECT_MOVE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_OBJECT_SEND,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_OBJECT_TRANSFER_ABORT,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_READ,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_REQUEST_CANCEL,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_SESSION_CLOSE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_SESSION_OPEN,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_STORAGE_IDS_GET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_STORAGE_INFO_GET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_THUMB_GET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PIMA_WRITE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PRINTER_ACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PRINTER_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PRINTER_NAME_GET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PRINTER_READ,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PRINTER_SOFT_RESET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PRINTER_STATUS_GET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PRINTER_WRITE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PROLIFIC_ACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PROLIFIC_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PROLIFIC_IOCTL_ABORT_IN_PIPE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PROLIFIC_IOCTL_ABORT_OUT_PIPE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PROLIFIC_IOCTL_GET_DEVICE_STATUS,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PROLIFIC_IOCTL_GET_LINE_CODING,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PROLIFIC_IOCTL_PURGE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PROLIFIC_IOCTL_REPORT_DEVICE_STATUS_CHANGE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PROLIFIC_IOCTL_SEND_BREAK,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PROLIFIC_IOCTL_SET_LINE_CODING,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PROLIFIC_IOCTL_SET_LINE_STATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PROLIFIC_READ,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PROLIFIC_RECEPTION_START,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PROLIFIC_RECEPTION_STOP,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_PROLIFIC_WRITE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_STORAGE_ACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_STORAGE_DEACTIVATE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_STORAGE_MEDIA_CAPACITY_GET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_STORAGE_MEDIA_FORMAT_CAPACITY_GET,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_STORAGE_MEDIA_MOUNT,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_STORAGE_MEDIA_OPEN,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_STORAGE_MEDIA_READ,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_STORAGE_MEDIA_WRITE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_STORAGE_REQUEST_SENSE,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_STORAGE_START_STOP,
            TmlDefines.TML_UX_TRACE_HOST_CLASS_STORAGE_UNIT_READY_TEST,
            TmlDefines.TML_UX_TRACE_HOST_STACK_CLASS_INSTANCE_CREATE,
            TmlDefines.TML_UX_TRACE_HOST_STACK_CLASS_INSTANCE_DESTROY,
            TmlDefines.TML_UX_TRACE_HOST_STACK_CONFIGURATION_DELETE,
            TmlDefines.TML_UX_TRACE_HOST_STACK_CONFIGURATION_ENUMERATE,
            TmlDefines.TML_UX_TRACE_HOST_STACK_CONFIGURATION_INSTANCE_CREATE,
            TmlDefines.TML_UX_TRACE_HOST_STACK_CONFIGURATION_INSTANCE_DELETE,
            TmlDefines.TML_UX_TRACE_HOST_STACK_CONFIGURATION_SET,
            TmlDefines.TML_UX_TRACE_HOST_STACK_DEVICE_ADDRESS_SET,
            TmlDefines.TML_UX_TRACE_HOST_STACK_DEVICE_CONFIGURATION_GET,
            TmlDefines.TML_UX_TRACE_HOST_STACK_DEVICE_CONFIGURATION_SELECT,
            TmlDefines.TML_UX_TRACE_HOST_STACK_DEVICE_DESCRIPTOR_READ,
            TmlDefines.TML_UX_TRACE_HOST_STACK_DEVICE_GET,
            TmlDefines.TML_UX_TRACE_HOST_STACK_DEVICE_REMOVE,
            TmlDefines.TML_UX_TRACE_HOST_STACK_DEVICE_RESOURCE_FREE,
            TmlDefines.TML_UX_TRACE_HOST_STACK_ENDPOINT_INSTANCE_CREATE,
            TmlDefines.TML_UX_TRACE_HOST_STACK_ENDPOINT_INSTANCE_DELETE,
            TmlDefines.TML_UX_TRACE_HOST_STACK_ENDPOINT_RESET,
            TmlDefines.TML_UX_TRACE_HOST_STACK_ENDPOINT_TRANSFER_ABORT,
            TmlDefines.TML_UX_TRACE_HOST_STACK_HCD_REGISTER,
            TmlDefines.TML_UX_TRACE_HOST_STACK_INITIALIZE,
            TmlDefines.TML_UX_TRACE_HOST_STACK_INTERFACE_ENDPOINT_GET,
            TmlDefines.TML_UX_TRACE_HOST_STACK_INTERFACE_INSTANCE_CREATE,
            TmlDefines.TML_UX_TRACE_HOST_STACK_INTERFACE_INSTANCE_DELETE,
            TmlDefines.TML_UX_TRACE_HOST_STACK_INTERFACE_SET,
            TmlDefines.TML_UX_TRACE_HOST_STACK_INTERFACE_SETTING_SELECT,
            TmlDefines.TML_UX_TRACE_HOST_STACK_NEW_CONFIGURATION_CREATE,
            TmlDefines.TML_UX_TRACE_HOST_STACK_NEW_DEVICE_CREATE,
            TmlDefines.TML_UX_TRACE_HOST_STACK_NEW_ENDPOINT_CREATE,
            TmlDefines.TML_UX_TRACE_HOST_STACK_RH_CHANGE_PROCESS,
            TmlDefines.TML_UX_TRACE_HOST_STACK_RH_DEVICE_EXTRACTION,
            TmlDefines.TML_UX_TRACE_HOST_STACK_RH_DEVICE_INSERTION,
            TmlDefines.TML_UX_TRACE_HOST_STACK_TRANSFER_REQUEST,
            TmlDefines.TML_UX_TRACE_HOST_STACK_TRANSFER_REQUEST_ABORT,
            TmlDefines.TML_UX_TRACE_ERROR,
            TmlDefines.TML_TRACE_USER_EVENT_START
        };
    }
}
