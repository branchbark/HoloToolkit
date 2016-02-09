//////////////////////////////////////////////////////////////////////////
// SyncTestbed.h
//
// Contains all the setup and objects for testing scenarios with the sync system
//
// Copyright (C) 2014 Microsoft Corp.  All Rights Reserved
//////////////////////////////////////////////////////////////////////////

#pragma once

#include "SyncTestObject.h"

namespace CommonDesktopTests
{
	//////////////////////////////////////////////////////////////////////////
	class SyncTestbedConnectionListener : public XTools::RefCounted, public XTools::IncomingXSocketListener
	{
	public:
		virtual void OnNewConnection(const XTools::XSocketPtr& newConnection) XTOVERRIDE;

		std::vector<XTools::XSocketPtr> m_connections;
	};


	DECLARE_PTR(SyncTestbedConnectionListener)


	//////////////////////////////////////////////////////////////////////////
	class SyncTestbed : public XTools::RefCounted, public LogWriter
	{
	public:
		SyncTestbed(bool bConnectOnSight);

		void ResetTestBed();

		void WaitTillFullySynced();

		void ValidateSyncState();

		void ValidatePair(const Sync::SyncManagerPtr& syncMgr1, const SyncObjectPtr& syncObj1, const Sync::SyncManagerPtr& syncMgr2, const SyncObjectPtr& syncObj2) const;

		virtual void WriteLogEntry(const std::string& message) const;

		XSocketManagerPtr m_serverSocketMgr;
		XSocketManagerPtr m_mslice1SocketMgr;
		XSocketManagerPtr m_mslice2SocketMgr;
		XSocketManagerPtr m_onsight1SocketMgr;
		XSocketManagerPtr m_onsight2SocketMgr;

		Sync::SyncManagerPtr m_serverSyncMgr;
		Sync::SyncManagerPtr m_client1SyncMgr;
		Sync::SyncManagerPtr m_client2SyncMgr;
		Sync::SyncManagerPtr m_onsight1SyncMgr;
		Sync::SyncManagerPtr m_onsight2SyncMgr;

		SyncObjectPtr m_serverRoot;
		SyncObjectPtr m_client1Root;
		SyncObjectPtr m_client2Root;
		SyncObjectPtr m_onsight1Root;
		SyncObjectPtr m_onsight2Root;

		UserPtr m_userServer;
		UserPtr m_userClient1;
		UserPtr m_userOnSight1;
		UserPtr m_userClient2;
		UserPtr m_userOnSight2;

		bool m_bConnectOnSight;

	private:
		NetworkConnectionImplPtr m_serverConnection1;
		NetworkConnectionImplPtr m_serverConnection2;

		NetworkConnectionImplPtr m_clientConnection1A;
		NetworkConnectionImplPtr m_clientConnection1B;

		NetworkConnectionImplPtr m_clientConnection2A;
		NetworkConnectionImplPtr m_clientConnection2B;

		NetworkConnectionImplPtr m_onsightConnection1;
		NetworkConnectionImplPtr m_onsightConnection2;
	};

	DECLARE_PTR(SyncTestbed)
}