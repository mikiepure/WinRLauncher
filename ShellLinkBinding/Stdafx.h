// stdafx.h : include file for standard system include files,
// or project specific include files that are used frequently, but
// are changed infrequently

#pragma once

// Include Windows Headers
#include <shlobj.h>					// IShellLink
#include <msi.h>					// MAX_FEATURE_CHARS, MsiGetShortcutTarget, MsiGetComponentPath

// Load Windows Libraries
#pragma comment(lib, "Ole32.lib")	// CoCreateInstance
#pragma comment(lib, "Msi.lib")		// MAX_FEATURE_CHARS, MsiGetShortcutTarget, MsiGetComponentPath

// C++/CLI Header
#include <msclr/marshal.h>
