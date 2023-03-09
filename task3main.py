import cv2
import numpy as np 
import mediapipe as mp
#imports the open cv2 files and mediapipe files neccesary for face tracking

#this program implemenets an headtracking as well as eye tracking using imported files such as open cv, numpy and media pipe
video_cap = cv2.VideoCapture(0) # this enables our video capture 

while(True):
    #captures frame by frame 
    face_cascade = cv2.CascadeClassifier("C:\Python\Python310\Lib\site-packages\cv2\data\haarcascade_frontalface_default.xml")
    eye_cascade = cv2.CascadeClassifier("C:\Python\Python310\Lib\site-packages\cv2\data\haarcascade_eye.xml")
    ret, frame = video_cap.read()

    # our operations on the frame come here
    col = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)

    faces = face_cascade.detectMultiScale(frame, 1.3,5)

    for (x,y,w,h) in faces:
            cv2.rectangle(frame,(x,y), (x+w, y+h), (255,0,0), 2) 
            cv2.addText("human detected")
            roi_gray = frame[y:y+h, x:x+w]
            roi_color = frame[y:y+h, x:x+w]
            eyes = eye_cascade.detectMultiScale(roi_gray)
    for (ex, ey,ew, eh) in eyes:
        cv2.rectangle(roi_color, (ex,ey), (ex+ew, ey+eh),(0,255,0),2)

    #display the resulting frame 
    cv2.imshow("video_live", frame)
    if cv2.waitKey(1) & 0xFF == ord('q'):
        break


    
    #when everything done, realease the capture
    #video_cap.release()