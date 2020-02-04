# -*- mode: python -*-

block_cipher = None


a = Analysis(['laczenie_stron_myszkow2.py'],
             pathex=['C:\\Users\\Dell\\Desktop'],
             binaries=[],
             datas=[],
             hiddenimports=[],
             hookspath=[],
             runtime_hooks=[],
             excludes=[],
             win_no_prefer_redirects=False,
             win_private_assemblies=False,
             cipher=block_cipher)
pyz = PYZ(a.pure, a.zipped_data,
             cipher=block_cipher)
exe = EXE(pyz,
		  Tree('data', prefix='data'),
          a.scripts,
          a.binaries,
          a.zipfiles,
          a.datas,
          name='laczenie_stron_myszkow',
          debug=False,
          strip=False,
          upx=True,
          console=True )
