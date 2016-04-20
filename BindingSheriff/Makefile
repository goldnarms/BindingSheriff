XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=../Sheriff
PROJECT=$(PROJECT_ROOT)/Sheriff.xcodeproj
TARGET=Sheriff
BTOUCH=/Developer/MonoTouch/usr/bin/btouch

all: libSheriffUniversal.a

libSheriff-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libSheriff-arm64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libSheriff-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libSheriffUniversal.a: libSheriff-armv7.a libSheriff-i386.a libSheriff-arm64.a
	lipo -create -output $@ $^

clean:
	-rm -f *.a *.dll