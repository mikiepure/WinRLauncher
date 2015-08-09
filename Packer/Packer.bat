SET PROJECT_NAME=WinRLauncher

SET EXE_WINR_LAUNCH=WinRLauncher.exe
SET PATH_WINR_LAUNCH="..\WinRLauncher\bin\Release\%EXE_WINR_LAUNCH%"

SET DLL_SHELL_LINK=ShellLinkBinding.dll
SET PATH_SHELL_LINK="..\Release\%DLL_SHELL_LINK%"

SET ARCHIVER_7ZIP="C:\Program Files\7-Zip\7z.exe"



MKDIR "%PROJECT_NAME%"

COPY "..\ReadMe.md" "%PROJECT_NAME%\ReadMe.md"
IF NOT {%ERRORLEVEL%} == {0} (
	ECHO "[E] �t�@�C�� ReadMe.md �̃R�s�[�Ɏ��s���܂����B"
	ECHO "[E] �o�b�`�����𒆒f���܂��B"
	PAUSE
	EXIT
)

COPY %PATH_WINR_LAUNCH% "%PROJECT_NAME%\%EXE_WINR_LAUNCH%"
IF NOT {%ERRORLEVEL%} == {0} (
	ECHO "[E] �t�@�C�� WinRLauncher.exe �̃R�s�[�Ɏ��s���܂����B"
	ECHO "[E] �o�b�`�����𒆒f���܂��B"
	PAUSE
	EXIT
)

COPY %PATH_SHELL_LINK% "%PROJECT_NAME%\%DLL_SHELL_LINK%"
IF NOT {%ERRORLEVEL%} == {0} (
	ECHO "[E] �t�@�C�� ShellLinkBinding.dll �̃R�s�[�Ɏ��s���܂����B"
	ECHO "[E] �o�b�`�����𒆒f���܂��B"
	PAUSE
	EXIT
)

%ARCHIVER_7ZIP% a "%PROJECT_NAME%.zip" "%PROJECT_NAME%"
IF NOT {%ERRORLEVEL%} == {0} (
	ECHO "[E] �t�@�C�� %PROJECT_NAME%.zip �̐����Ɏ��s���܂����B"
	ECHO "[E] �o�b�`�����𒆒f���܂��B"
	PAUSE
	EXIT
)

RMDIR /S /Q "%PROJECT_NAME%"
