#ifndef PCH_H
#define PCH_H

// Include Windows Headers
#include <shlobj.h>					// IShellLink
#include <msi.h>					// MAX_FEATURE_CHARS, MsiGetShortcutTarget, MsiGetComponentPath

// Load Windows Libraries
#pragma comment(lib, "Ole32.lib")	// CoCreateInstance
#pragma comment(lib, "Msi.lib")		// MAX_FEATURE_CHARS, MsiGetShortcutTarget, MsiGetComponentPath

// C++/CLI Header
#include <msclr/marshal.h>

#endif //PCH_H
