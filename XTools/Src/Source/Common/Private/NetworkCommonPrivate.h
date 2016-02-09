//////////////////////////////////////////////////////////////////////////
// NetworkCommonPrivate.h
//
// Contains types and definitions used by multiple pieces of the networking 
// code that should not be exposed to other areas of the code
//
// Copyright (C) 2014 Microsoft Corp.  All Rights Reserved
//////////////////////////////////////////////////////////////////////////

#pragma once

XTOOLS_NAMESPACE_BEGIN

struct NetworkHeader 
{
	byte				m_messageID;
	MessagePriority		m_priority;
	MessageReliability	m_reliability;
	MessageChannel		m_channel;
};

// The enums in the header should all use only one byte, making the total header size 4 bytes.
// Use a static assert to make sure this is always the case.  
static_assert(sizeof(NetworkHeader) == 4, "NetworkHeader is not the expected size");


enum TunnelMsgType : byte
{
	RemotePeerConnected = 0,
	RemotePeerDisconnected,
	TunneledMessage
};

// The initial size of the buffer used to concatenate outgoing messages with Broadcast and tunnel headers
static const uint32 kDefaultMessageBufferSize = 1024;

XTOOLS_NAMESPACE_END
