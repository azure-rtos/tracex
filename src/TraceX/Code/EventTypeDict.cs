﻿using System.Collections.Generic;

namespace AzureRTOS.TraceManagement.Code
{
    public static class EventTypeDict
    {
        public static Dictionary<uint, string> typeStringDict = new Dictionary<uint, string>()
        {
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_THREAD_PTR, "Thread Ptr" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_PREVIOUS_STATE, "Previous State" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_STACK_POINTER, "Stack Pointer" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_NEXT_THREAD_PTR, "Next Thread Ptr" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_NEW_STATE, "New State" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_STACK_PTR, "Stack Ptr" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_ISR_NUMBER, "ISR Number" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_SYSTEM_STATE, "System State" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_PREEMPT_DISABLE, "Preempt Disable" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_STACK, "Stack" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_POOL_PTR, "Pool Ptr" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_MEMORY_PTR, "Memory Ptr" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_WAIT_OPTION, "Wait Option" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_REMAINING_BLOCKS, "Remaining Blocks" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_POOL_START, "Pool Start" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_TOTAL_BLOCKS, "Total Blocks" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_BLOCK_SIZE, "Block Size" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_SUSPENDED_COUNT, "Suspended Count" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_SUSPENDED, "Suspended" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_SIZE_REQUESTED, "Size Requested" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_START_PTR, "Start Ptr" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_POOL_SIZE, "Pool Size" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_AVAILABLE_BYTES, "Available Bytes" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_GROUP_PTR, "Group Ptr" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_REQUESTED_FLAGS, "Requested Flags" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_CURRENT_FLAGS, "Current Flags" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_GET_OPTION, "Get Option" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_FLAGS_TO_SET, "Flags to Set" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_SET_OPTION, "Set Option" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_NEW_INTERRUPT_POSTURE, "New Interrupt Posture" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_MUTEX_PTR, "Mutex Ptr" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_INHERITANCE, "Inheritance" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_OWNING_THREAD, "Owning Thread" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_OWN_COUNT, "Own Count" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_QUEUE_PTR, "Queue Ptr" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_MESSAGE_SIZE, "Message Size" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_QUEUE_START, "Queue Start" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_QUEUE_SIZE, "Queue Size" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_SOURCE_PTR, "Source Ptr" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_ENQUEUED, "Enqueued" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_DESTINATION_PTR, "Destination Ptr" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_SEMAPHORE_PTR, "Semaphore Ptr" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_CURRENT_COUNT, "Current Count" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_CEILING, "Ceiling" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_INITIAL_COUNT, "Initial Count" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_PRIORITY, "Priority" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_STACK_SIZE, "Stack Size" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_THREAD_STATE, "Thread State" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_NEW_THRESHOLD, "New Threshold" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_OLD_THRESHOLD, "Old Threshold" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_NEW_PRIORITY, "New Priority" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_OLD_PRIORITY, "Old Priority" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_SLEEP_VALUE, "Sleep Value" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_NEW_TIMESLICE, "New Timeslice" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_OLD_TIMESLICE, "Old Timeslice" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_CURRENT_TIME, "Current Time" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_NEW_TIME, "New Time" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_TIMER_PTR, "Timer Ptr" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_INITIAL_TICKS, "Initial Ticks" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_RESCHEDULE_TICKS, "Reschedule Ticks" },
            {(uint)EventInfoTypes.types.TX_EVENT_INFO_ENABLE, "Enable" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_MEDIA_PTR, "Media Ptr" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_SECTOR, "Sector" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_TOTAL_MISSES, "Total Misses" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_CACHE_SIZE, "Cache Size" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_DIRTY_SECTORS, "Dirty Sectors" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_NUMBER_OF_SECTORS, "Number of Sectors" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_BUFFER, "Buffer" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_DIRECTORY_NAME, "Directory Name" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_ATTRIBUTES, "Attributes" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_RETURN_PATH_NAME, "Return Path Name" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_NEW_PATH_NAME, "New Path Name" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_LOCAL_PATH_PTR, "Local Path Ptr" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_SHORT_FILE_NAME, "Short File Name" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_LONG_FILE_NAME, "Long File Name" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_OLD_DIRECTORY_NAME, "Old Directory Name" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_NEW_DIRECTORY_NAME, "New Directory Name" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_FILE_PTR, "File Ptr" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_SIZE, "Size" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_PREVIOUS_SIZE, "Previous Size" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_NEW_SIZE, "New Size" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_FILE_NAME, "File Name" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_ACTUAL_SIZE_ALLOCATED, "Actual Size Allocated" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_FILE_SIZE, "File Size" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_YEAR, "Year" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_MONTH, "Month" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_OPEN_TYPE, "Open Type" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_BUFFER_PTR, "Buffer Ptr" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_REQUEST_SIZE, "Request Size" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_ACTUAL_SIZE, "Actual Size" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_BYTE_OFFSET, "Byte Offset" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_SEEK_FROM, "Seek From" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_PREVIOUS_OFFSET, "Previous Offset" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_OLD_FILE_NAME, "Old File Name" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_NEW_FILE_NAME, "New File Name" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_BYTES_WRITTEN, "Bytes Written" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_SCRATCH_MEMORY, "Scratch Memory" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_SCRATCH_MEMORY_SIZE, "Scratch Memory Size" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_ERRORS, "Errors" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_ROOT_ENTRIES, "Root Entries" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_SECTORS, "Sectors" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_SECTORS_PER_CLUSTER, "Sectors Per Cluster" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_MEDIA_DRIVER, "Media Driver" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_MEMORY_PTR, "Memory Ptr" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_MEMORY_SIZE, "Memory Size" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_LOGICAL_SECTOR, "Logical Sector" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_BYTES_READ, "Bytes Read" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_AVAILABLE_BYTES_PTR, "Available Bytes Ptr" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_AVAILABLE_CLUSTERS, "Available Clusters" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_VOLUME_NAME, "Volume Name" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_VOLUME_SOURCE, "Volume Source" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_BYTE_WRITTEN, "Byte Written" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_DAY, "Day" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_HOUR, "Hour" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_MINUTE, "Minute" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_SECOND, "Second" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_SOURCE_UNICODE, "Source Unicode" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_SOURCE_LENGTH, "Source Length" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_SHORT_NAME, "Short Name" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_NEW_NAME, "New Name" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_UNICODE_NAME, "Unicode Name" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_LENGTH, "Length" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_SOURCE_SHORT_NAME, "Source Short Name" },
            {(uint)EventInfoTypes.types.FX_EVENT_INFO_SOURCE_UNICODE_NAME, "Source Unicode Name" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_IP_PTR, "IP Ptr" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_SOURCE_IP_ADDRESS, "Source IP Address" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_PACKET_PTR, "Packet Ptr" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_DESTINATION_IP_ADDRESS, "Destination IP Address" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_HEADER_WORD_0, "Header Word 0" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_HEADER_0, "Header 0" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_PACKET_LENGTH, "Packet Length" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_LENGTH, "Length" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_SEQUENCE, "Sequence" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_SOCKET_PTR, "Socket Ptr" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_TARGET_IP_ADDRESS, "Target IP Address" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_HEADER_WORD_1, "Header Word 1" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_NUMBER_OF_RETRIES, "Number of Retries" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_PREVIOUS_STATE, "Previous State" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_NEW_STATE, "New State" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_PACKET_SIZE, "Packet Size" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_ENTRIES_INVALIDATED, "Entries Invalidated" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_IP_ADDRESS, "IP Address" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_PHYSICAL_MSW, "Physical MSW" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_PHYSICAL_LSW, "Physical LSW" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_ARP_CACHE_MEMORY, "ARP Cache Memory" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_ARP_CACHE_SIZE, "ARP Cache Size" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_ARPS_SENT, "ARPs Sent" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_ARP_RESPONSES, "ARP Responses" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_ARPS_RECEIVED, "ARPs Received" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_ENTRIES_DELETED, "Entries Deleted" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_PINGS_SENT, "Pings Sent" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_PING_RESPONSES, "Ping Responses" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_PINGS_RECEIVED, "Pings Received" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_DATA_PTR, "Data Ptr" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_DATA_SIZE, "Data Size" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_REPORTS_SENT, "Reports Sent" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_QUERIES_RECEIVED, "Queries Received" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_GROUPS_JOINED, "Groups Joined" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_GROUP_ADDRESS, "Group Address" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_IP_ADDRESS_CHANGED_NOTIFY, "IP Address Changed Notify" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_ADDITIONAL_INFO, "Additional Info" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_NETWORK_MASK, "Network Mask" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_DEFAULT_POOL, "Default Pool" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_COMMAND, "Command" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_RETURN_VALUE, "Return Value" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_GATEWAY_ADDRESS, "Gateway Address" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_BYTES_SENT, "Bytes Sent" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_BYTES_RECEIVED, "Bytes Received" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_PACKETS_DROPPED, "Packets Dropped" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_WAIT_OPTION, "Wait Option" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_DESTINATION_IP, "Destination IP" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_TYPE_OF_SERVICE, "Type of Service" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_NEEDED_STATUS, "Needed Status" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_ACTUAL_STATUS, "Actual Status" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_POOL_PTR, "Pool Ptr" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_PACKET_TYPE, "Packet Type" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_AVAILABLE_PACKETS, "Available Packets" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_NEW_PACKET_PTR, "New Packet Ptr" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_DATA_START, "Data Start" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_BUFFER_START, "Buffer Start" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_BYTES_COPIED, "Bytes Copied" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_PAYLOAD_SIZE, "Payload Size" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_MEMORY_PTR, "Memory Ptr" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_MEMORY_SIZE, "Memory Size" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_TOTAL_PACKETS, "Total Packets" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_FREE_PACKETS, "Free Packets" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_EMPTY_REQUESTS, "Empty Requests" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_PACKET_STATUS, "Packet Status" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_REQUESTS_SENT, "Requests Sent" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_RESPONSES_RECEIVED, "Responses Received" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_INVALIDS, "Invalids" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_PORT, "Port" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_SERVER_IP, "Server IP" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_SERVER_PORT, "Server Port" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_FREE_PORT, "Free Port" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_INVALID_PACKETS, "Invalid Packets" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_SOCKET_STATE, "Socket State" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_LISTEN_QUEUE_SIZE, "Listen Queue Size" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_WINDOW_SIZE, "Window Size" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_MSS, "MSS" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_PEER_MSS, "Peer MSS" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_RX_SEQUENCE, "RX Sequence" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_RECEIVE_NOTIFY, "Receive Notify" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_TX_SEQUENCE, "TX Sequence" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_DESIRED_STATE, "Desired State" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_QUEUE_DEPTH, "Queue Depth" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_TIMEOUT, "Timeout" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_QUEUE_MAXIMUM, "Queue Maximum" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_INTERFACE_INDEX, "Interface Index" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_BYTES_AVAILABLE, "Bytes Available" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_NETWORK_ADDRESS, "Network Address" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_NET_MASK, "Net Mask" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_MTU_SIZE, "MTU Size" },
            {(uint)EventInfoTypes.types.NX_EVENT_INFO_BUFFER_LENGTH, "Buffer Length" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_IP_PTR, "IP Ptr" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_PACKET_PTR, "Packet Ptr" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_IP_VERSION, "IP Version" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_IP_ADDRESS, "IP Address" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_PORT, "Port" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_UDP_SOCKET_PTR, "UDP Socket Ptr" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_INTERFACE_ID, "Interface ID" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_TCP_SOCKET_PTR, "TCP Socket Ptr" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_SOCKET_PTR, "Socket Ptr" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_PACKET_SIZE, "Packet Size" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_DESTINATION_IP, "Destination IP" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_PHYSICAL_MSW, "Physical MSW" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_PHYSICAL_LSW, "Physical LSW" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_IP_ADDRESS_LSW, "IP Address LSW" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_PREFIX_LENGTH, "Prefix Length" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_PROTOCOL, "Protocol" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_TYPE_OF_SERVICE, "Type of Service" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_ROUTER_ADDR_LSW, "Router Addr LSW" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_ROUTER_LIFETIME, "Router Lifetime" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_ADDRESS_LSW, "Address LSW" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_INTERFACE_INDEX, "Interface Index" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_PEER_IP_ADDRESS, "Peer IP Address" },
            {(uint)EventInfoTypes.types.NXD_EVENT_INFO_PEER_PORT, "Peer Port" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_CLASS, "Class" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_CLASS_INSTANCE, "Class Instance" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_CONFIGURATION, "Configuration" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_DEVICE, "Device" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_DEVICE_ADDRESS, "Device Address" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_DEVICE_INDEX, "Device Index" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_HCD, "Hcd" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_PARENT, "Parent" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_PORT_INDEX, "Port Index" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_ENDPOINT, "Endpoint" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_HCD_NAME, "Hcd Name" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_INTERFACE, "Interface" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_DEVICE_OWNER, "Device Owner" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_TRANSFER_REQUEST, "Transfer Request" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_DATA_POINTER, "Data Pointer" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_REQUESTED_LENGTH, "Requested Length" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_AUDIO_CONTROL, "Audio Control" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_AUDIO_SAMPLING, "Audio Sampling" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_PARAMETER, "Parameter" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_DEVICE_STATUS, "Device Status" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_HID_CLIENT_NAME, "Hid Client Name" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_HID_CLIENT_INSTANCE, "Hid Client Instance" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_CLIENT_REPORT, "Client Report" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_PORT, "Port" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_PORT_STATUS, "Port Status" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_PIMA_DEVICE, "Pima Device" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_EVENT_CODE, "Event Code" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_TRANSACTION_ID, "Transaction ID" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_PARAMETER1, "Parameter1" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_OBJECT, "Object" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_OBJECT_HANDLE, "Object Handle" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_OBJECT_BUFFER, "Object Buffer" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_OBJECT_LENGTH, "Object Length" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_DATA_LENGTH, "Data Length" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_PIMA_SESSION, "Pima Session" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_STORAGE_ID_ARRAY, "Storage ID Array" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_STORAGE_ID_LENGTH, "Storage ID Length" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_STORAGE_ID, "Storage ID" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_STORAGE, "Storage" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_PRINTER_STATUS, "Printer Status" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_SECTOR, "Sector" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_MEDIA, "Media" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_SECTOR_START, "Sector Start" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_SECTOR_COUNT, "Sector Count" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_START_STOP_SIGNAL, "Start Stop Signal" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_INTERFACE_VALUE, "Interface Value" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_ALTERNATE_SETTING_VALUE, "Alternate Setting Value" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_CLASS_NAME, "Class Name" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_INTERFACE_NUMBER, "Interface Number" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_REQUEST_TYPE, "Request Type" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_REQUEST_VALUE, "Request Value" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_REQUEST_INDEX, "Request Index" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_CONFIGURATION_VALUE, "Configuration Value" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_DESCRIPTOR_TYPE, "Descriptor Type" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_COMPLETION_CODE, "Completion Code" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_BUFFER, "Buffer" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_HID_EVENT, "Hid Event" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_PIMA_EVENT, "Pima Event" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_OBJ_FORMAT_CODE, "Obj Format Code" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_OBJ_ASSOCIATION, "Obj Association" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_OFFSET_REQUESTED, "Offset Requested" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_LENGTH_REQUESTED, "Length Requested" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_RESPONSE_CODE, "Response Code" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_NUMBER_PARAMETER, "Number Parameter" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_PIMA_PARAMETER_1, "Pima Parameter 1" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_RNDIS_OID, "Rndis OID" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_LUN, "Lun" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_NUMBER_SECTORS, "Number Sectors" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_SENSE_KEY, "Sense Key" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_CODE, "Code" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_USBX_ERROR, "USBX Error" },
            {(uint)EventInfoTypes.types.UX_EVENT_INFO_ERROR_TYPE, "Error Type" }
        };
    }
}
